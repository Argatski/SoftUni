using System;

namespace _01.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Random rnd = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];

                int index = rnd.Next(words.Length);

                words[i] = words[index];
                words[index] = word;
            }

            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
        }
    }
}
