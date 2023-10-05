using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_PersistentBugger
{
    internal class Program
    {

        public static int Persistence(long n)
        {
            if (n < 10)
                return 0;
            else
                return Persistence(DigitMutiply(n)) + 1;
        }

        public static int DigitMutiply(long n)
        {
            var result = Convert.ToInt32(n.ToString()[0].ToString());
            for (int i = 1; i < n.ToString().Length; i++)
            {
                result *= Convert.ToInt32(n.ToString()[i].ToString());
            }
            return result;
        }
    }
}
