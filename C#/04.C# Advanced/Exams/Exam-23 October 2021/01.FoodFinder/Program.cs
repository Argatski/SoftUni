using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.FoodFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            char[] firstInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();

            Queue<char> vowels = new Queue<char>(firstInput);

            char[] secondInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();

            Stack<char> consonants = new Stack<char>(secondInput);

            List<string> words = new List<string>
            {
                ("pear"),
                ("flour"),
                ("pork"),
                ("olive")
            };

            //Processing
            Processing(vowels, consonants, words);

            //Print Result

        }

        private static void Processing(Queue<char> vowels, Stack<char> consonants, List<string> words)
        {
            Dictionary<int, char[]> dict = new Dictionary<int, char[]>
            {
                { 0,new char[4]},
                { 1,new char[5]},
                { 2,new char[4]},
                { 3,new char[5]},
            };

            while (consonants.Any())
            {
                char currentVowel = vowels.Peek();
                char currentConsonant = consonants.Peek();

                bool isVowel = false;

                for (int i = 0; i < words.Count(); i++)
                {
                    int index = -1;

                    if (words[i].Contains(currentVowel))
                    {
                        isVowel = true;

                        index = words[i].IndexOf(currentVowel);

                        if (dict.ContainsKey(i))
                        {
                            dict[i][index] = currentVowel;
                        }

                    }
                    if (words[i].Contains(currentConsonant))
                    {
                        index = words[i].IndexOf(currentConsonant);

                        if (dict.ContainsKey(i))
                        {
                            dict[i][index] = currentConsonant;
                        }

                    }
                }

                if (isVowel)
                {
                    vowels.Enqueue(currentVowel);
                    vowels.Dequeue();
                }
                consonants.Pop();
            }


            //Cheked the words
            List<string> result = new List<string>();

            foreach (var word in dict)
            {
                string text = "";
                foreach (var item in word.Value)
                {
                    text += item.ToString();
                }

                if (words.Contains(text))
                {
                    result.Add(text);
                }
            }

            

            //Print result
            Print(result);

        }

        private static void Print(List<string> result)
        {

            Console.WriteLine($"Words found: {result.Count}");

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

        }
    }
}
