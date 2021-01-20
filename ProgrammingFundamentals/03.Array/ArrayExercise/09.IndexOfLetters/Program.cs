using System;
using System.Linq;

namespace _09.IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read of console word
            string word = Console.ReadLine().ToLower();

            // Create array of intigers with lenght equal word.
            int[] number = new int[word.Length];

            // Read and write in array
            for (int i = 0; i < word.Length; i++)
            {
                number[i] = word[i];

                Console.WriteLine($"{word[i]} -> {number[i] - 97}"); // number[i] -97 because the task is "a" = 0.
            }
            //Another solution is create array of characters and parse this characters in intigers.

        }
    }
}
