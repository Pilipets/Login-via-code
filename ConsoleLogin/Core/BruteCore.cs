using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLogin
{
    class BruteCore : HttpMethods
    {
        HttpMethods login;
        WebProxy defaultProxy;
        WebProxy currentProxy;
        bool keepSending;

        public void TestPage(string username, string password)
        {
            string postData = postPattern;
            postPattern.Replace("'USER'", username);
            postPattern.Replace("'PASS'", password);

            if (isTokenRequired)
            {
                CookieContainer myCookies = new CookieContainer();
                string pageCode = Get(currentProxy, ref myCookies);
                string token = Process(pageCode);
                keepSending = !Post(postData, currentProxy, myCookies);
            }
            else
            {
                keepSending = !Post(postData, currentProxy);
            }
        }

        private string Process(string pageCode)
        {
            return "";
        }
    }
}
