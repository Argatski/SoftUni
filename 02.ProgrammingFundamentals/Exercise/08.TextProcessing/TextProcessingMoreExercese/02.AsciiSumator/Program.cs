using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AsciiSumator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            //Processing
            List<int> result = GetAllCharactersBetween(first, second, text);

            //Sum
            int sum = result.Sum();

            Console.WriteLine(sum);
        }

        static List<int> GetAllCharactersBetween(char first, char second, string text)
        {
            List<int> arrNum = new List<int>(); 

            for (int k = 0; k < text.Length; k++)
            {
                if (text[k] > first && text[k] < second)
                {
                    arrNum.Add((int)text[k]);
                }
            }
            
            return arrNum;
        }
    }
}
