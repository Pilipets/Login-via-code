using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLogin
{
    class HttpMethods
    {
        protected async Task<Tuple<string, CookieContainer>> Get(string url, string referer, WebProxy proxy)
        {
            CookieContainer cookies = new CookieContainer();
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "GET";
            req.CookieContainer = cookies;
            req.ContentType = "application/x-www-form-urlencoded";
            req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/70.0.3538.77 Safari/537.36";
            req.Referer = referer;
            req.Proxy = proxy;
            req.Timeout = 2000;

            try
            {
                HttpWebResponse resp = req.GetResponse() as HttpWebResponse;
                cookies.Add(resp.Cookies);

                string pageSrc;
                using (StreamReader sr = new StreamReader(resp.GetResponseStream()))
                {
                    pageSrc = await sr.ReadToEndAsync();
                }

                return Tuple.Create(WebUtility.HtmlDecode(pageSrc), cookies);
            }
            catch(WebException ex)
            {
                if(ex.Status == WebExceptionStatus.Timeout)
                {
                    throw new WebException("Provided proxy isn't responding" +
                        ex.Status);
                }
                else
                    throw new WebException(ex.Message + ex.Status);
            }
        }

        protected async Task<bool> Post(string postData, string url, string referer, WebProxy proxy, 
            Encoding encoding, string indicateString, CookieContainer cookies = null)
        {

            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "POST";
            req.CookieContainer = cookies;
            req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/70.0.3538.77 Safari/537.36";
            req.Referer = referer;
            req.ContentType = "application/x-www-form-urlencoded";
            req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8";
            req.Proxy = proxy;
            req.Timeout = 2000;

            using (Stream postStream = await req.GetRequestStreamAsync())
            {
                byte[] postBytes = encoding.GetBytes(postData);
                await postStream.WriteAsync(postBytes, 0, postBytes.Length);
            }
            try
            {
                HttpWebResponse resp = await req.GetResponseAsync() as HttpWebResponse;
                cookies.Add(resp.Cookies);
                string pageSrc = "";
                using (StreamReader sr = new StreamReader(resp.GetResponseStream()))
                {
                    pageSrc = await sr.ReadToEndAsync();
                }

                return (!pageSrc.Contains(indicateString));
            }
            catch(WebException ex)
            {
                if (ex.Status == WebExceptionStatus.Timeout)
                {
                    throw new WebException("Provided proxy isn't responding" +
                        ex.Status);
                }
                else
                    throw new WebException(ex.Message + ex.Status);
            }
        }
    }
}
