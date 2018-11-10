﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
namespace Syte_Hydra
{
    class HttpMethods
    {
        public static string Get(string url, string referer, ref CookieContainer cookies)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "GET";
            req.CookieContainer = cookies;
            req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/70.0.3538.77 Safari/537.36";
            req.Referer = referer;

            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            cookies.Add(resp.Cookies);

            string pageSrc;
            using (StreamReader sr = new StreamReader(resp.GetResponseStream()))
            {
                pageSrc = sr.ReadToEnd();
            }

            return pageSrc;
        }

        public static bool Post(string url, string postData, string referer, CookieContainer cookies)
        {
            string key = "<title>Ошибка входа - Все для студента</title>";

            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "POST";
            req.CookieContainer = cookies;
            req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/70.0.3538.67 Safari/537.36";
            req.Referer = referer;
            req.ContentType = "application/x-www-form-urlencoded";
            req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8";

            using (Stream postStream = req.GetRequestStream())
            {
                byte[] postBytes = Encoding.ASCII.GetBytes(postData);
                postStream.Write(postBytes, 0, postBytes.Length);
            }

            try
            {
                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
                cookies.Add(resp.Cookies);
                Console.WriteLine(resp.Headers);
            }
            catch(WebException ex)
            {
                Console.WriteLine(ex.Response.Headers);
            }



            string pageSrc = "";
            //using (StreamReader sr = new StreamReader(resp.GetResponseStream()))
            //{
            //    pageSrc = sr.ReadToEnd();
            //}

            return (!pageSrc.Contains(key));
        }
    }
}
