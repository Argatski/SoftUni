using System;
using System.Linq;

namespace _05.MagicExchangeableWords
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string[] words = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string firstWord = words[0];
            string secondWord = words[1];

            bool exchangeable = AreExchangeable(firstWord, secondWord);

            if (exchangeable == false)
            {
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine("true");
            }
        }

        static bool AreExchangeable(string first, string second)
        {
            bool isExchangeable = false;

            char[] newStr1 = first.Distinct().ToArray();
            char[] newStr2 = second.Distinct().ToArray();

            if (newStr1.Length == newStr2.Length)
            {
                isExchangeable = true;
            }
            return isExchangeable;
        }
    }
}
