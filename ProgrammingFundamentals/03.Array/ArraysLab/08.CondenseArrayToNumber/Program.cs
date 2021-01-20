using System;
using System.Linq;

namespace _08.CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int sum = 0;

            int count = number.Length;
            while (count > 1)
            {
                for (int k = 0; k < count - 1; k++)
                {
                    sum = number[k] + number[k + 1];
                    Console.WriteLine("{0}{1}", number[k], k == count - 2 ? string.Empty : " ");
                }
                Console.WriteLine();
                count--;
            }
        }

    }
}
