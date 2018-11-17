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
        Status progressLog;
        public string Name { get; set; }
        public bool isTokenRequired;
        public Encoding pageEncoding { get; set; }
        public string indicateString { get; set; }

        public string postPattern { get; set; }

        public string postUrl { get; set; }

        public string postReferer { get; set; }

        public string navigateUrl { get; set; }
        public string navigateReferer { get; set; }

        public LoginCore(Status console, string Name, string indicateString, string postPattern, string postUrl,
            string postReferer, string navigateUrl, string navigateReferer) : this(console)
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
        public LoginCore(Status console)
        {
            progressLog = console;
        }
        public Task<Tuple<string,CookieContainer>> Get(WebProxy proxy)
        {
            return base.Get(navigateUrl, navigateReferer, proxy);
            
        }
        public Task<bool> Post(string postData, WebProxy proxy, CookieContainer cookies = null)
        {
            return base.Post(postData, postUrl, postReferer, proxy, pageEncoding, indicateString, cookies);
        }
        public async Task<bool> Login(string username, string password, WebProxy proxy)
        {
            progressLog(string.Format("Checking: {0} <-> {1}", username, password));
            string postData = postPattern;
            postData = postData.Replace("'USER'", WebUtility.UrlEncode(username));
            postData = postData.Replace("'PASS'", WebUtility.UrlEncode(password));
            if (isTokenRequired)
            {
                var getData = await Get(proxy);
                string pageCode = getData.Item1;

                CookieContainer myCookies = getData.Item2;
                //string  token = Parser.GetBetween(pageCode, "name=\"__SART\" type=\"hidden\" value=\"", "\" />");
                string token = Parser.GetBetween2(pageCode, "name='user_token' value='", "' />");
                postData = postData.Replace("'TOKEN'", token);
                bool entered = await Post(postData, proxy, myCookies);
                if(entered)
                    progressLog(string.Format("Username: {0} <-> Password : {1}", username, password));
                return entered;
            }
            else
            {
                bool entered = await Post(postData, proxy);
                if (entered)
                    progressLog(string.Format("Username: {0} <-> Password : {1}", username, password));
                return entered;
            }
        }
        public async static Task<LoginCore> InitializeFromFile(Status console, string path)
        {
            var file = new FileStream(path, FileMode.Open, FileAccess.Read);
            var reader = new StreamReader(file);
            LoginCore newPage = new LoginCore(console);
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
