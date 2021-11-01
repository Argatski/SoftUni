using System;
using System.Collections.Generic;

namespace _06.CountSymbols
{
    class CountSymbols
    {
        static void Main(string[] args)
        {
            //Input 
            string text = Console.ReadLine();

            SortedDictionary<char/*symbol*/, int/*times*/> dict = new SortedDictionary<char, int>();

            //Count symbols
            CountSymbol(text, dict);

            //Print result count symbols
            Print(dict);
        }
        /// <summary>
        /// Print counts the occurrences symbol.
        /// </summary>
        /// <param name="dict"></param>
        private static void Print(SortedDictionary<char, int> dict)
        {
            foreach (var symbol in dict)
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
        }

        /// <summary>
        /// Count symbols occurrences
        /// </summary>
        /// <param name="text"></param>
        /// <param name="dict"></param>
        static void CountSymbol(string text, SortedDictionary<char, int> dict)
        {
            foreach (var symbol in text)
            {
                if (dict.ContainsKey(symbol) == false)
                {
                    dict.Add(symbol, 0);
                }
                dict[symbol]++;
            }
        }
    }
}

