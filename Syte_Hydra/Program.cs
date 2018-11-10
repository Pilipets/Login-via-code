using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syte_Hydra
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Net.CookieContainer myCookies = new System.Net.CookieContainer();
            string url = "https://www.twirpx.com/", referer = "";

            string mySrc = HttpMethods.Get(url, referer, ref myCookies);
            string token = GetBetween(mySrc, "name=\"__SART\" type=\"hidden\" value=\"", "=\" />");
            string username = "glebon1802@gmail.com";
            string password = "gleb2000";

            string postData = String.Format("ReturnUrl=%2F&AuthEmail={0}&AuthPassword={1}&__SART={2}%3D", username, password, token);

            bool result = HttpMethods.Post(url + "auth/login/", postData, "https://www.twirpx.com/", myCookies);


            if (result)
                Console.WriteLine(postData);
            else
                Console.WriteLine("Credentials are invalid");

            Console.ReadKey();
        }


        //<input type="hidden" name="user_token" value="45f1f9e364bda3b155ef96e890f1474f">
        static string GetBetween(string msg, string start, string stop)
        {
            int startIndex = msg.IndexOf(start) + start.Length;
            int stopIndex = msg.IndexOf(stop, startIndex);

            return msg.Substring(startIndex, stopIndex - startIndex);
        }
    }
}
