using System;

namespace _08.TextProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            string word;
            while ((word = Console.ReadLine()) != "end")
            {

                string reverseWord = string.Empty;

                for (int i = word.Length - 1; i >= 0; i--)
                {
                    reverseWord += word[i];
                }

                Console.WriteLine($"{word} = {reverseWord}");

            }
        }
    }
}
