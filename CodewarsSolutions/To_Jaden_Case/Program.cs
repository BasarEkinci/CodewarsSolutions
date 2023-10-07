using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace To_Jaden_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        static string ToJadenCase(string pharase)
        {
            if (string.IsNullOrEmpty(pharase))
            {
                throw new ArgumentException("An empty or null clause cannot be passed");
            }
            string[] words = pharase.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (!string.IsNullOrEmpty(words[i]))
                {
                    char[] wordArray= words[i].ToCharArray();
                    wordArray[0] = char.ToUpper(wordArray[0]);
                    words[i] = new string(wordArray);
                }
            }
            return string.Join(" ", words);
        }
    }
}
