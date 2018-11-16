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
        LoginCore page;
        public BindingList<LoginCore> pages;
        WebProxy defaultProxy;
        WebProxy currentProxy;
        bool keepSending;

        public BruteCore()
        {
            defaultProxy = WebProxy.GetDefaultProxy();
            keepSending = false;
            pages = new BindingList<LoginCore>();
        }
        public async void TestPage(string username, string password)
        { 
            await page.Login(username, password, currentProxy);
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
                }
            }
            keepSending = false;
        }

        public void AddPage(LoginCore siteInfo)
        {
            pages.Add(siteInfo);
        }

        public async void ReadPagesFromFile(string path)
        {
            FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);
            var reader = new StreamReader(file);
            do
            {
                string _filePath = await reader.ReadLineAsync();
                _filePath = string.Format("{0}\\Files\\{1}",path.Substring(0, path.LastIndexOf('\\')),_filePath);
                LoginCore newPage = await LoginCore.InitializeFromFile(_filePath);
                pages.Add(newPage);
            } while (reader.Peek() >= 0);
            reader.Dispose();
            file.Dispose();
            page = pages[0];
        }
        public void StopBrute()
        {
            keepSending = false;
        }

        internal void SetCurrentPage(LoginCore loginCore) => page = loginCore;
    }
}
