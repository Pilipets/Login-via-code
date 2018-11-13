using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLogin
{
    class BruteInfo
    {
        public bool isTokenRequired = true;
        public Encoding encoding { get; set; } = Encoding.UTF8;
        public string key = "<title>Ошибка входа - Все для студента</title>";
        public string postPattern { get; set; }
            = "ReturnUrl=%2F&AuthEmail='USER'&AuthPassword='PASS'&__SART='TOKEN'%3D";

        public string postUrl { get; set; } = "https://www.twirpx.com/auth/login/";
        public string postReferer { get; set; } = "";

        public string navigateUrl { get; set; } = "https://www.twirpx.com/";
        public string navigateReferer { get; set; } = "";
        
    }
}
