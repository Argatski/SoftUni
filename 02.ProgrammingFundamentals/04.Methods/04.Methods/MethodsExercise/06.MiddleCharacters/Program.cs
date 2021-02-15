using System;
using System.Linq;

namespace _06.MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string text = Console.ReadLine();

            //Output
            MiddleCharacters(text);
        }

        //Solution
        static void MiddleCharacters(string text)
        {
            if (text.Length % 2 == 0)
            {
                Console.WriteLine($"{text[text.Length / 2-1]}" + $"{text[text.Length/2]}");
            }
            else
            {
                Console.WriteLine($"{text[text.Length / 2]}");
            }
        }
    }
}