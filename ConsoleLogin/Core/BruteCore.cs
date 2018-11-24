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
        event Status ChangeUI;

        LoginCore page;
        string defaultUserName = "admin";

        public BindingList<LoginCore> pages;
        WebProxy defaultProxy;
        WebProxy currentProxy;

        public BindingList<Tuple<string, int>> proxyList;
        bool keepSending;


        public BruteCore(Status updaterUI)
        {
            ChangeUI += updaterUI;

            defaultProxy = null;
            keepSending = false;
            pages = new BindingList<LoginCore>();
            proxyList = new BindingList<Tuple<string, int>>();
        }
        public Task<bool> TestPageAsync(string username, string password)
        {
            return page.Login(username, password, currentProxy);
        }
        public async Task StartBruteAsync(int frequencySeconds, string userName, string passFile)
        {
            ChangeUI(this, new LoginEventArgs(EventType.Progress, "Async Brute Started"));
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
            ChangeUI(this, new LoginEventArgs(EventType.Progress, "Async Brute Finished"));
        }

        public void AddPage(LoginCore siteInfo)
        {
            pages.Add(siteInfo);
            ChangeUI(this, new LoginEventArgs(EventType.Progress, 
                "Added new Page " + siteInfo.Name));
        }

        public async Task ReadPagesFromFile(string path)
        {
            ChangeUI(this, new LoginEventArgs(EventType.Progress, 
                "Started reading default pages from file" + path));
            FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);
            var reader = new StreamReader(file);
            do
            {
                string _filePath = await reader.ReadLineAsync();
                _filePath = string.Format("{0}\\Files\\{1}",path.Substring(0, path.LastIndexOf('\\')),_filePath);
                LoginCore newPage = new LoginCore(ChangeUI);
                await newPage.InitializeFromFile( _filePath);
                pages.Add(newPage);
            } while (reader.Peek() >= 0);
            reader.Dispose();
            file.Dispose();
            page = pages[0];
            ChangeUI(this, new LoginEventArgs(EventType.Progress,
                "Finished reading default pages from file" + path));
            ChangeUI(this, new LoginEventArgs(EventType.Progress,
                page.Name + " has been set as default brute page"));
        }
        public void StopBrute()
        {
            ChangeUI(this, new LoginEventArgs(EventType.Progress, "Async brute was terminated"));
            keepSending = false;
        }

        public void SetCurrentPage(LoginCore loginCore)
        {
            page = loginCore;
        }

        public void ReadProxyFromFileAsync(string path)
        {
            ChangeUI(this, new LoginEventArgs(EventType.Progress,
                "Started reading proxy from file" + path));

            FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);
            var reader = new StreamReader(file);
            do
            {
                string proxy = reader.ReadLine();
                int delimiter = proxy.IndexOf(' ');
                string ip = proxy.Substring(0, delimiter);
                int port = Convert.ToInt32(proxy.Substring(delimiter + 1));
                proxyList.Add(Tuple.Create(ip,port));
            } while (reader.Peek() >= 0);
            reader.Dispose();
            file.Dispose();
        }
    }
}
