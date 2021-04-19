using System;
using System.Collections.Generic;

namespace _05.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string text = Console.ReadLine();

            SortedDictionary<char, int> dict = new SortedDictionary<char, int>();

            //Count symbols
            CountSymbols(text, dict);

            //Print result
            Print(dict);

        }

        static void Print(SortedDictionary<char, int> dict)
        {
            foreach (var symbol in dict)
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
        }

        static void CountSymbols(string text, SortedDictionary<char, int> dict)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (dict.ContainsKey(text[i])==false)
                {
                    dict.Add(text[i], 0);
                }
                dict[text[i]]++;
            }
        }
    }
}
