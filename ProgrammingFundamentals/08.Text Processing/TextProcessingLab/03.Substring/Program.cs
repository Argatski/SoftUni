using System;

namespace _03.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string word = Console.ReadLine().ToLower();
            string text = Console.ReadLine().ToLower();

            //Solution
            while (text.Contains(word))
            {
                int index = text.IndexOf(word);

                text = text.Remove(index, word.Length);
            }

            Console.WriteLine(text);
        }
    }
}
