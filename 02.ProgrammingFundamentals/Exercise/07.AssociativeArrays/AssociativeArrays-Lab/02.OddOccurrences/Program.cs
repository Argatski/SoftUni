using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().ToLower()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> list = Proccesing(words);

            PrintOddWords(list);
        }

        static void PrintOddWords(Dictionary<string, int> list)
        {

            list.Where(w => w.Value % 2 == 0);

            foreach (var item in list)
            {
                if (item.Value % 2 == 1)
                {
                    Console.Write($"{item.Key} ");
                }
            }
        }

        static Dictionary<string, int> Proccesing(string[] words)
        {
            Dictionary<string, int> list = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (list.ContainsKey(word))
                {
                    list[word]++;
                }
                else
                {
                    list.Add(word, 1);
                }
            }
            return list;
        }
    }
}
