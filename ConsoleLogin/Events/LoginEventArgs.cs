using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLogin
{
    delegate void Status(object sender, LoginEventArgs e);
    enum EventType
    {
        Error,
        Progress,
        Credentials
    }
    class LoginEventArgs
    {
        public EventType Type { get; set; }
        public string Message { get; set; }
        public LoginEventArgs(EventType type, string message)
        {
            Type = type;
            Message = message;
        }
    }
}
