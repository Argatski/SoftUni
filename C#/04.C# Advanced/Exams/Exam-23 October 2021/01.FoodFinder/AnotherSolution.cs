﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Food_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, char[]> words = new Dictionary<string, char[]>();
            words.Add("pear", "pear".ToCharArray());
            words.Add("flour", "flour".ToCharArray());
            words.Add("pork", "pork".ToCharArray());
            words.Add("olive", "olive".ToCharArray());
            var vowelsArr = Console.ReadLine().Where(x => !Char.IsWhiteSpace(x)).ToArray();
            var consonantsArr = Console.ReadLine().Where(x => !Char.IsWhiteSpace(x)).ToArray();
            Queue<char> vowels = new Queue<char>(vowelsArr);
            Stack<char> consonants = new Stack<char>(consonantsArr);
            int count = 0;

            while (true)
            {
                if (consonants.Count == 0) break;
                char currVow = vowels.Dequeue();
                char curCons = consonants.Pop();

                var newPear = words["pear"].Where(x => x != currVow).Where(x => x != curCons).ToArray();
                words["pear"] = newPear;

                var newFlour = words["flour"].Where(x => x != currVow).Where(x => x != curCons).ToArray();

                words["flour"] = newFlour;

                var newPork = words["pork"].Where(x => x != currVow).Where(x => x != curCons).ToArray();

                words["pork"] = newPork;

                var newOlive = words["olive"].Where(x => x != currVow).Where(x => x != curCons).ToArray();

                words["olive"] = newOlive;

                vowels.Enqueue(currVow);
            }

            foreach (var word in words)
            {
                if (word.Value.Length == 0) count++;
            }


            Console.WriteLine($"Words found: {count}");
            foreach (var word in words)
            {
                if (word.Value.Length == 0)
                {
                    Console.WriteLine(word.Key);
                }
            }
        }
    }
}
