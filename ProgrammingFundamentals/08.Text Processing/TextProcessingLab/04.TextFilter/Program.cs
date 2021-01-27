using System;

namespace _04.TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string[] words = Console.ReadLine()
                 .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            string text = Console.ReadLine();

            //Solution
            string asterisks = string.Empty;

            foreach (var word in words)
            {
                string replacement = new string('*', word.Length);

                if (text.Contains(word))
                {
                    text = text.Replace(word, replacement);
                }
            }
            Console.WriteLine(text);

        }
    }
}
