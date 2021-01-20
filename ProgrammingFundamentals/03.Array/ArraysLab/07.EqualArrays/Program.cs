using System;
using System.Linq;

namespace _07.EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstLine = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] secondLine = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int sum = 0;


            for (int i = 0; i < firstLine.Length; i++)
            {
                if (firstLine[i] != secondLine[i])
                {
                    Console.WriteLine($"Arrays are not identical. " +
                        $"Found difference at {i} index");
                    return;
                }
                else
                {
                    sum += firstLine[i];
                }
            }
            Console.WriteLine($"Arrays are identical. Sum: {sum}");

        }
    }
}
