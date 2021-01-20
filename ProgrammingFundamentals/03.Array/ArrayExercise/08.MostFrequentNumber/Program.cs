using System;
using System.Linq;

namespace _08.MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();

            int currentNumber = 0;
            int bestNumber = 0;
            int count = 0;

            for (int i = 0; i < number.Length; i++)
            {
                for (int k = 1; k < number.Length; k++)
                {
                    if (number[i]==number[k])
                    {
                        count++;
                        currentNumber = number[i];
                    }
                }
            }
        }
    }
}
