using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleLogin
{
    class LoginCore:HttpMethods
    {
        public string Name { get; set; }
        public bool isTokenRequired = true;
        public Encoding pageEncoding { get; set; } = Encoding.UTF8;
        public string indicateString { get; set; } = "<title>Ошибка входа - Все для студента</title>";

        public string postPattern { get; set; }
            = "ReturnUrl=%2F&AuthEmail='USER'&AuthPassword='PASS'&__SART='TOKEN'%3D";

        public string postUrl { get; set; } = "https://www.twirpx.com/auth/login/";

        public string postReferer { get; set; } = "";

        public string navigateUrl { get; set; } = "https://www.twirpx.com/";
        public string navigateReferer { get; set; } = "";

        public LoginCore(string Name, string indicateString, string postPattern, string postUrl,
            string postReferer, string navigateUrl, string navigateReferer)
        {
            this.Name = Name;
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
            return await base.Post(postData, postUrl, postReferer, proxy, pageEncoding, indicateString, cookies);
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
        public async static Task<LoginCore> InitializeFromFile(string path)
        {
            var file = new FileStream(path, FileMode.Open, FileAccess.Read);
            var reader = new StreamReader(file);
            LoginCore newPage = new LoginCore();
            do
            {
                string _line = await reader.ReadLineAsync();
                string property = _line.Substring(0, _line.IndexOf(':'));
                string value = null;
                try
                {
                    value = _line.Substring(_line.IndexOf(':') + 2);
                }
                catch(Exception)
                {
                    value = "";
                }
                if (property == "pageEncoding")
                {
                    Encoding tmpEncoding = Encoding.Default;
                    if (value == "UTF8")
                        tmpEncoding = Encoding.UTF8;
                    else if (value == "ASCII")
                        tmpEncoding = Encoding.ASCII;
                    typeof(LoginCore).GetProperty(property).SetValue(newPage, tmpEncoding);
                }
                else
                {
                    try
                    {
                        typeof(LoginCore).GetProperty(property).SetValue(newPage, value);
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                
                
            } while (reader.Peek() >= 0);
            reader.Dispose();
            file.Dispose();
            newPage.isTokenRequired = newPage.postPattern.Contains("'TOKEN'");
            return newPage;
        }
    }
}
