using System;
using System.Linq;

namespace _07.MaxSequenceOfIncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int maxStart = 0;
            int maxLen = 1;

            int currentStart = 0;
            int currentLen = 1;


            for (int i = 1; i < number.Length; i++)
            {

                if (number[i] > number[i - 1])
                {
                    currentLen++;
                    if (currentLen > maxLen)
                    {
                        maxLen = currentLen;
                        maxStart = currentStart;
                    }
                }
                else
                {
                    currentStart = i;
                    currentLen = 1;
                }
            }

            for (int i = maxStart; i < maxStart + maxLen; i++)
            {
                Console.Write("{0} ", number[i]);
            }
            Console.WriteLine();

        }
    }
}
