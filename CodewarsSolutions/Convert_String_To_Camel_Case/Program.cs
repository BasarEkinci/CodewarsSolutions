using System;

namespace Convert_String_To_Camel_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ToCamelCase("the-stealth-warrior"));       
            Console.WriteLine(ToCamelCase("The_Stealth_Warrior"));       
            Console.WriteLine(ToCamelCase("The_Stealth-Warrior"));
            Console.ReadLine(); 
        }

        static string ToCamelCase(string str)
        {
            char[] delimiters = { '-', '_' };
            string[] words = str.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            if (words.Length == 0)
            {
                return str;
            }

            string camelCase = words[0];
            bool isFirstWordCapitalized = char.IsUpper(words[0][0]);

            for (int i = 1; i < words.Length; i++)
            {
                string word = words[i];
                if (!string.IsNullOrEmpty(word))
                {
                    camelCase += char.ToUpper(word[0]) + word.Substring(1);
                }
            }

            return isFirstWordCapitalized
                ? camelCase
                : char.ToLower(camelCase[0]) + camelCase.Substring(1);
        }
    }
}
