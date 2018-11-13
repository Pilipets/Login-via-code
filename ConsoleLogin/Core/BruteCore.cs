using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLogin
{
    class BruteCore
    {
        LoginCore page;
        WebProxy defaultProxy;
        WebProxy currentProxy;
        bool keepSending;

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
    }
}
