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
        event Status ChangeUI;

        public string Name { get; set; }
        bool isTokenRequired;
        public Encoding pageEncoding { get; set; }
        public string indicateString { get; set; }

        public string navigateUrl { get; set; }
        public string navigateReferer { get; set; }

        public string postPattern { get; set; }
        string postUrl { get; set; }
        string postReferer { get; set; }

        string TokenFieldName { get; set; }
        public string ActionType { get; set; }

        public LoginCore(Status updaterUI, string Name, string postPattern, string indicateString, 
            string navigateUrl, string navigateReferer, string formAction) : this(updaterUI)
        {
            this.Name = Name;
            this.postPattern = postPattern;
            this.indicateString = indicateString;
            this.navigateUrl = navigateUrl;
            this.navigateReferer = navigateReferer;
            this.ActionType = formAction;

            FillPrivateFields();
        }
        public LoginCore(Status updaterUI)
        {
            ChangeUI += updaterUI;
        }
        private Task<Tuple<string,CookieContainer>> Get(WebProxy proxy)
        {
            return base.Get(navigateUrl, navigateReferer, proxy);         
        }
        private Task<bool> Post(string postData, WebProxy proxy, CookieContainer cookies = null)
        {
            return base.Post(postData, postUrl, postReferer, proxy, pageEncoding, indicateString, cookies);
        }
        public async Task<bool> Login(string username, string password, WebProxy proxy)
        {
            string postData = postPattern;
            postData = postData.Replace("'USER'", WebUtility.UrlEncode(username));
            postData = postData.Replace("'PASS'", WebUtility.UrlEncode(password));

            bool Authorized = false;
            if (isTokenRequired)
            {
                var getData = await Get(proxy);
                string pageCode = getData.Item1;

                CookieContainer myCookies = getData.Item2;
                string token = Parser.GetToken(pageCode, ActionType, TokenFieldName);
                postData = postData.Replace("'TOKEN'", WebUtility.UrlEncode(token));
                Authorized = await Post(postData, proxy, myCookies);
            }
            else
            {
                Authorized = await Post(postData, proxy);
            }
            if (Authorized)
            {
                ChangeUI(this, new LoginEventArgs(EventType.Progress,
                    string.Format("Found new Credentials: ({0} <-> {1})", username, password)));
                ChangeUI(this, new LoginEventArgs(EventType.Credentials,
                    string.Format("({0} <-> {1})", username, password)));
            }
            else
                ChangeUI(this, new LoginEventArgs(EventType.Progress,
                    string.Format("Invalid credentials: ({0} <-> {1})", username, password)));
            return Authorized;
        }
        public async Task InitializeFromFile(string path)
        {
            var file = new FileStream(path, FileMode.Open, FileAccess.Read);
            var reader = new StreamReader(file);
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
                    typeof(LoginCore).GetProperty(property).SetValue(this, tmpEncoding);
                }
                else
                {
                    try
                    {
                        typeof(LoginCore).GetProperty(property).SetValue(this, value);
                    }
                    catch(Exception)
                    {
                        throw new Exception("Cannot Set page property: " + property +
                            "; Error in file" + file);
                    }
                }
                
                
            } while (reader.Peek() >= 0);
            reader.Dispose();
            file.Dispose();

            FillPrivateFields();

            ChangeUI(this, new LoginEventArgs(EventType.Progress, "Added new page" + this.Name));
        }

        private void FillPrivateFields()
        {
            this.isTokenRequired = this.postPattern.Contains("'TOKEN'");
            postUrl = MakePost(navigateUrl, ActionType);
            postReferer = MakePost(navigateReferer, ActionType);

            if(isTokenRequired)
            {
                int start = postPattern.LastIndexOf('&');
                int end = postPattern.LastIndexOf("'TOKEN'");
                TokenFieldName = postPattern.Substring(start+1, end - (start+2));
            }
        }
        private string MakePost(string navigateAdress, string actionAdress)
        {
            if (navigateAdress == "" || actionAdress == "")
                return navigateAdress;

            string result = navigateAdress;
            if (actionAdress[0] == '/' && navigateAdress[navigateAdress.Length - 1] == '/')
                result += actionAdress.Substring(1);
            else if (actionAdress[0] != '/' && navigateAdress[navigateAdress.Length - 1] != '/')
                result += '/' + actionAdress;
            else
                result += actionAdress;
            return result;
        }
    }
}
