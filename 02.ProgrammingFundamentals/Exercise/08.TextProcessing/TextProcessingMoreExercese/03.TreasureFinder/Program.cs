using System;
using System.Linq;

namespace _03.TreasureFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int[] keyNumber = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            //Solution
            Processing(keyNumber);

        }

        static void Processing(int[] keyNumber)
        {
            while (true)
            {
                string text = Console.ReadLine();

                if (text == "find")
                {
                    break;
                }


                string messages = DecryptingText(text, keyNumber);

                Print(messages);
            }
        }

        static void Print(string messages)
        {
            string typeTreasure = TreasureFinder('&', messages);
            string coordinates = CoordinatesFinder('<', '>', messages);

            Console.WriteLine($"Found {typeTreasure} at {coordinates}");
        }

        static string CoordinatesFinder(char v1, char v2, string messages)
        {
            int startIndex = messages.IndexOf(v1);
            int lastIndex = messages.LastIndexOf(v2);
            int lenght = lastIndex - startIndex;

            string result = messages.Substring(startIndex+1, lenght-1); 
            return result;
        }

        private static string TreasureFinder(char v, string messages)
        {
            int startIndex = messages.IndexOf(v);
            int lastIndex = messages.LastIndexOf(v);
            int lenght = lastIndex - startIndex;


            string result = messages.Substring(startIndex+1, lenght-1);

            return result;
        }

        static string DecryptingText(string text, int[] key)
        {
            string result = "";
            int position = 0;

            for (int i = 0; i < text.Length; i++)
            {

                if (i >= key.Length)
                {
                    position %= key.Length;
                }

                result += (char)(text[i] - key[position]);
                position++;
            }

            return result;
        }
    }
}
