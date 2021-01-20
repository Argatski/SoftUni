using System;
using System.Linq;

namespace _05.LongestIncreasingSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int maxLength = 0;
            int lastIndex = -1;

            int[] len = new int[number.Length];
            int[] prev = new int[number.Length];


            for (int i = 0; i < number.Length; i++)
            {
                len[i] = 1;
                prev[i] = -1;

                for (int k = 0; k < i; k++)
                {
                    if (number[k]<number[i]&& len[k]+1>len[i])
                    {
                        len[i] = len[k] + 1;
                        prev[i] = k;
                    }
                }
                if (len[i]>maxLength)
                {
                    maxLength = len[i];
                    lastIndex = i;
                }
            }

            int[] LIS = new int[maxLength];
            int currentIndex = maxLength - 1;

            while (lastIndex!=-1)
            {
                LIS[currentIndex] = number[lastIndex];
                currentIndex--;
                lastIndex = prev[lastIndex];
            }
            Console.WriteLine(string.Join(" ",LIS));
        }
    }
}
