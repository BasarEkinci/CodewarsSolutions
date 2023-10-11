using System;
using System.Diagnostics.Eventing.Reader;

namespace Multiples_of_3_or_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution(10));
            Console.WriteLine(Solution(20));
            Console.WriteLine(Solution(200));
            Console.WriteLine(Solution(0));
        }
        
        static int Solution(int value)
        {
            int result = 0;
            if(value > 0) 
            {
                for (int i = 0; i < value; i++)
                {
                    if (i % 15 == 0)                   
                        result += i;                   
                    else if (i % 3 == 0)                   
                        result += i;                   
                    else if (i % 5 == 0)
                        result += i; 
                }
            }
            return result;
        }
    }
}
