using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Repeat
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public static string RepeatString(int n, string s)
        {
            return string.Concat(Enumerable.Repeat(s, 5));
        }
    }
}
