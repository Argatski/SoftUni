using System;
using System.Text;

namespace _03.UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string text = Console.ReadLine();

            //Solution
            string utf = string.Empty;

            for (int i = 0; i < text.Length; i++)
            {
                var code = $"{(int)text[i]:x4}".ToLower();
                utf += $"\\u{code}";
            }

            Console.WriteLine(utf);
        }
    }
}
