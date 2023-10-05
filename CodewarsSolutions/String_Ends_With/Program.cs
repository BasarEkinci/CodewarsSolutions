using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Ends_With
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public static bool Solution(string str,string ending)
        {
            if(ending.Length > str.Length)
                return false;
            else
            {
                if(str.EndsWith(ending))
                    return true;
                else 
                    return false;
            }
        }
    }
}
