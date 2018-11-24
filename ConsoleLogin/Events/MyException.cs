using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLogin.Events
{
    class MyException:Exception
    {
        object sender;
        string message;
        MyException(object sender, string message)
        {
            this.sender = sender;
            this.message = message;
        }
    }
}
