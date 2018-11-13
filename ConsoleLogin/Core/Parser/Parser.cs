using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLogin
{
    class Parser
    {
        public static string GetBetween(string msg, string start, string stop)
        {
            var tokens = new List<String>();
            int i1 = 0, i2 = 0;

            while (true)
            {
                int tmp = msg.IndexOf(start, i2);
                if (tmp > 0)
                {
                    i1 = tmp + start.Length;
                    i2 = msg.IndexOf(stop, i1);
                    tokens.Add(msg.Substring(i1, i2 - i1));
                }
                else
                    break;
            }
            foreach (var elem in tokens)
                Console.WriteLine(elem);

            tokens[1] = tokens[1].Replace("&#x2B;", "%2B");
            return tokens[1];

            //int startIndex = msg.IndexOf(start) + start.Length;
            //int stopIndex = msg.IndexOf(stop, startIndex);
            //Console.WriteLine(msg.Substring(startIndex, stopIndex - startIndex));
            //return msg.Substring(startIndex, stopIndex - startIndex);
        }
    }
}
