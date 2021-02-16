using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.LargestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .OrderByDescending(n => n)
                .ToList();

            if (numbers.Count < 3)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write($"{numbers[i] + " "}");
                }
            }
        }
    }
}
