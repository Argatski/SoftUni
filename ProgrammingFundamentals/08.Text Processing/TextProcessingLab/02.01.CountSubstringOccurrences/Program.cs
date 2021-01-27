using System;

namespace _02._01.CountSubstringOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input 
            string text = Console.ReadLine().ToLower();
            string substring = Console.ReadLine().ToLower();

            //Solution
            Processing(text, substring);

        }

        static void Processing(string text, string appersText)
        {
            int count = 0;
            int startIndex = 0;

            while (text.IndexOf(appersText,startIndex,StringComparison.OrdinalIgnoreCase)>=0)
            {
                count++;
                startIndex = text.IndexOf(appersText, startIndex, StringComparison.OrdinalIgnoreCase) + 1;
            }

            Console.WriteLine(count);
        }
    }
}
