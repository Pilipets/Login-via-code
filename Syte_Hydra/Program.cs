using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Syte_Hydra
{
    delegate void ErrorMessage(string message);
    delegate void UpdateUI(Action method);
    class Program
    {
        static int Tmp { get; set; } = 0;
        static void Main(string[] args)
        {

            Console.ReadKey();
        }
        static void Display(string message)
        {
            Console.WriteLine(message);
        }
        //<input type="hidden" name="user_token" value="45f1f9e364bda3b155ef96e890f1474f">
        static string GetBetween(string msg, string start, string stop)
        {
            var tokens = new List<String>();
            int i1 = 0, i2 = 0;

            while(true)
            {
                int tmp= msg.IndexOf(start, i2);
                if (tmp > 0)
                {
                    i1 = tmp + start.Length;
                    i2 = msg.IndexOf(stop, i1);
                    tokens.Add(msg.Substring(i1, i2 - i1));
                }
                else
                    break;
            }
            foreach (var elem in tokens)
                Console.WriteLine(elem);

            //tokens[1] = tokens[1].Replace("&#x2B;", "%2B");
            if (tokens[0].Contains('+'))
                return tokens[0];
            else
                return tokens[1];

            //int startIndex = msg.IndexOf(start) + start.Length;
            //int stopIndex = msg.IndexOf(stop, startIndex);
            //Console.WriteLine(msg.Substring(startIndex, stopIndex - startIndex));
            //return msg.Substring(startIndex, stopIndex - startIndex);
        }
        static void ParallelStuff()
        {
            var instance1 = new TestClass(Display);
            instance1.DoSomeWork();
            //instance1.DoSomeWork2();
            Console.WriteLine("Hello, buddy");
        }
        static void ProxyStuff()
        {
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            string localIp = "?";
            foreach (var ip in host.AddressList)
                if (ip.AddressFamily.ToString() == "InterNetwork")
                    localIp = ip.ToString();

            WebRequest req = HttpWebRequest.Create("http://filmitorrent.org/tags/2018/");
            req.Proxy = null;
            WebResponse resp = null;
            try
            {
                resp = req.GetResponse();
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex.Status);
            }
            StreamReader answer = new StreamReader(resp.GetResponseStream());
            var code = answer.ReadToEnd();
            Console.WriteLine(code);
        }
        static void LoginStuff()
        {
            System.Net.CookieContainer myCookies = new System.Net.CookieContainer();
            string url = "https://www.twirpx.com/", referer = "";

            string mySrc = HttpMethods.Get(url, referer, ref myCookies);
            string token = GetBetween(mySrc, "name=\"__SART\" type=\"hidden\" value=\"", "\" />");
            token = WebUtility.UrlEncode(token);
            string username = "glebon1802@gmail.com";
            username = WebUtility.UrlEncode(username);
            string password = "gleb2df000";
            password = WebUtility.UrlEncode(password);

            string postData = String.Format("ReturnUrl=/&AuthEmail={0}&AuthPassword={1}&__SART={2}", username, password, token);

            bool result = HttpMethods.Post(url + "auth/login/", postData, referer, myCookies);



            if (result)
                Console.WriteLine(postData);
            else
                Console.WriteLine("Credentials are invalid");

            Console.ReadKey();
        }
    }
}
