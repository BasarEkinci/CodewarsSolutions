using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseWords("double  spaces"));
            Console.ReadLine();
        }

        static string ReverseWords(string str)
        {
            string[] words = str.Split(new char[] { ' ' });

            for (int i = 0; i < words.Length; i++)
            {
                char[] wordChars = words[i].ToCharArray();
                Array.Reverse(wordChars);
                words[i] = new string(wordChars);
            }

            string result = string.Join(" ", words);

            return result;
        }
    }
}
