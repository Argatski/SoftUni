using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _01._Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
                    //Input
            double[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            Dictionary<double, int> occurrences = new Dictionary<double, int>();

            //Processing
            CountSameValues(numbers,occurrences);

            //Print result
            Print(occurrences);
        }

        static void Print(Dictionary<double, int> occurrences)
        {
            foreach (var item in occurrences)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }

        static void CountSameValues(double[] numbers, Dictionary<double, int> occurrences)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (!occurrences.ContainsKey(numbers[i]))
                {
                    occurrences.Add(numbers[i], 0);
                }
                occurrences[numbers[i]]++;
            }
        }
    }
}
