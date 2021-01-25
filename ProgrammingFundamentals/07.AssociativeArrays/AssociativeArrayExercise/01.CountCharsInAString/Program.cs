using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string text = Console.ReadLine().ToLower();

            Dictionary<char, int> countChars = new Dictionary<char, int>();

            //Solution

            Processing(text, countChars);
            PrintCharsCount(countChars);
        }

        static void PrintCharsCount(Dictionary<char, int> countChars)
        {
            foreach (var item in countChars)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }

        static void Processing(string w, Dictionary<char, int> countChars)
        {
            for (int i = 0; i < w.Length; i++)
            {
                char current = w[i];

                if (char.IsWhiteSpace(current))
                {
                    continue;
                }
                if (countChars.ContainsKey(current))
                {
                    countChars[current]++;
                }
                else
                {
                    countChars.Add(current, 1);
                }
            }
        }
    }
}

