using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Needle_In_The_Haystack
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public static string FindNeedle(object[] haystack)
        {
            return "found the needle at position " + Array.IndexOf(haystack, "needle");
        }
    }
}
