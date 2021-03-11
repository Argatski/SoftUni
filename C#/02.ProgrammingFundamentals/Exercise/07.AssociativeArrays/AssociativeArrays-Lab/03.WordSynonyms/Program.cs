using System;
using System.Collections.Generic;

namespace _03.WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int n = int.Parse(Console.ReadLine());

            //Solution
            Dictionary<string, List<string>> synonym = new Dictionary<string, List<string>>();

            Processing(n, synonym);

            //Print result
            PrintSynonym(synonym);

        }

        static void PrintSynonym(Dictionary<string, List<string>> synonym)
        {
            foreach (var word in synonym)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ",word.Value)}");
            }
        }

        static void Processing(int n, Dictionary<string, List<string>> list)
        {
            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (list.ContainsKey(word) == false)
                {
                    list.Add(word, new List<string>());
                }

                list[word].Add(synonym);
            }
        }
    }
}
