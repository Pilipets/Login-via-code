using System;
using System.Collections.Generic;
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

        public string postPattern { get; set; }
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

        public string Get(WebProxy proxy, ref CookieContainer cookies)
        {
            return base.Get(navigateUrl, navigateReferer, proxy, ref cookies);
        }
        public bool Post(string postData, WebProxy proxy, CookieContainer cookies = null)
        {
            return base.Post(postData, postUrl, postReferer, proxy, encoding, indicateString, cookies);
        }
        public bool Login(string username, string password, WebProxy proxy)
        {
            string postData = postPattern;
            postData = postData.Replace("'USER'", username);
            postData = postData.Replace("'PASS'", password);
            if (isTokenRequired)
            {
                CookieContainer myCookies = new CookieContainer();
                string pageCode = Get(proxy, ref myCookies);
                string  token = Parser.GetBetween(pageCode, "name=\"__SART\" type=\"hidden\" value=\"", "=\" />");
                postData = postData.Replace("'TOKEN'", token);
                return Post(postData, proxy, myCookies);
            }
            else
            {
                return Post(postData, proxy);
            }
        }
    }
}
