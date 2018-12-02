using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class Program
    {
        public static Task<bool> ThrowsException(string username, string password)
        {
            Console.WriteLine(username + ":" + password);
            throw new NullReferenceException();
        }

        public static Task ExtraCall(string username, string password)
        {
            return ThrowsException(username, password);
        }

        public static async void CatchException()
        {
            try
            {
                await Task.Run(() => ExtraCall("user", "pass"));
            }
            catch (Exception ex)
            {
                Console.WriteLine("caught it!");
                Console.WriteLine(ex.ToString());
            }
        }
        static void Main(string[] args)
        {
            CatchException();
            Console.ReadKey();
        }
    }
}
