using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counting_Duplicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DuplicateCount("aAbBCCd"));
            Console.ReadLine();
        }

        static int DuplicateCount(string str)
        {
            str = str.ToLower();
            List<char> chars = new List<char>();
            foreach (char c in str)
            {
                
                if (char.IsLetterOrDigit(c))
                {
                    if (chars.ContainsKey(c))
                    {
                        charCounts[c]++;
                    }
                    else
                    {
                        charCounts[c] = 1;
                    }
                }
            }
            int duplicateCount = charCounts.Count(kv => kv.Value > 1);
            return duplicateCount;
        }
    }
}
