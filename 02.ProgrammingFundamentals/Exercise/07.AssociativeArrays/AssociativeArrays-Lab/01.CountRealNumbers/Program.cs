using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(double.Parse)
                 .ToArray();

            SortedDictionary<double, int> sorted = new SortedDictionary<double, int>();

            int count = 0;

            foreach (var item in numbers)
            {
                if (sorted.ContainsKey(item))
                {
                    sorted[item]++;
                }
                else
                {
                    sorted.Add(item, 1);
                }
            }

            foreach (var num in sorted)
            {
                Console.WriteLine($"{num.Key} -> {num.Value}");
            }

        }
    }
}
