using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Every_Digit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SquareDigits(24);
            Console.ReadLine();
        }

        static int SquareDigits(int n)
        {
            string strNum = n.ToString();
            string result = "";

            foreach (char digit in strNum)
            {
                int intDigit = int.Parse(digit.ToString());
                int square = intDigit * intDigit;
                result += square.ToString();
            }
            return int.Parse(result);
        }
    }
}
