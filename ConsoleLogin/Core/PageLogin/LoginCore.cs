using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLogin
{
    class LoginCore:HttpMethods
    {
        public bool isTokenRequired = true;
        public Encoding encoding { get; set; } = Encoding.UTF8;
        public string indicateString = "<title>Ошибка входа - Все для студента</title>";

        public string postPattern { get; set }
            = "ReturnUrl=%2F&AuthEmail='USER'&AuthPassword='PASS'&__SART='TOKEN'%3D";

        public string postUrl { get; set; } = "https://www.twirpx.com/auth/login/";

        public string postReferer { get; set; } = "";

        public string navigateUrl { get; set; } = "https://www.twirpx.com/";
        public string navigateReferer { get; set; } = "";

        public LoginCore(string indicateString, string postPattern, string postUrl,
            string postReferer, string navigateUrl, string navigateReferer)
        {
            this.postPattern = postPattern;
            this.indicateString = indicateString;
            isTokenRequired = postPattern.Contains("'TOKEN'");
            this.postUrl = postUrl;
            this.postReferer = postReferer;
            this.navigateUrl = navigateUrl;
            this.navigateReferer = navigateReferer;
        }
        public LoginCore()
        {

        }
        public async Task<Tuple<string,CookieContainer>> Get(WebProxy proxy)
        {
            return await base.Get(navigateUrl, navigateReferer, proxy);
            
        }
        public async Task<bool> Post(string postData, WebProxy proxy, CookieContainer cookies = null)
        {
            return await base.Post(postData, postUrl, postReferer, proxy, encoding, indicateString, cookies);
        }
        public async Task<bool> Login(string username, string password, WebProxy proxy)
        {
            string postData = postPattern;
            postData = postData.Replace("'USER'", username);
            postData = postData.Replace("'PASS'", password);
            if (isTokenRequired)
            {
                var getData = await Get(proxy);
                string pageCode = getData.Item1;

                CookieContainer myCookies = getData.Item2;
                string  token = Parser.GetBetween(pageCode, "name=\"__SART\" type=\"hidden\" value=\"", "=\" />");
                postData = postData.Replace("'TOKEN'", token);
                return await Post(postData, proxy, myCookies);
            }
            else
            {
                return await Post(postData, proxy);
            }
        }
        public static List<LoginCore> InitializeFromFile(string path)
        {
            List<LoginCore> loginCores = new List<LoginCore>();
            var file = new FileStream(path, FileMode.Open, FileAccess.Read);
            var reader = new StreamReader(file);
            LoginCore newPage;
            do
            {
                newPage = new LoginCore();
                string _line = reader.ReadLine();
                string property = _line.Substring(0, _line.IndexOf(':'));
                string value = _line.Substring(_line.IndexOf(':') + 2);
                typeof(LoginCore).GetProperty(property).SetValue(newPage, value);
                if(property == "name")
                {
                    file.Seek(Encoding.ASCII.GetByteCount(_line), SeekOrigin.Current);
                    loginCores.Add(newPage);
                }
                
            } while (reader.Peek() >= 0);
            reader.Dispose();
            loginCores.Add(newPage);
            return loginCores;
        }
    }
}
