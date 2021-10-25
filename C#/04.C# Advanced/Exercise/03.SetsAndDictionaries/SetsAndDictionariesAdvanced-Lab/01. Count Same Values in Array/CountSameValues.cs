using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _01._Count_Same_Values_in_Array
{
    class CountSameValues
    {
        static void Main(string[] args)
        {

            //Input
            Dictionary<double, int> occurrences = new Dictionary<double, int>();

            double[] numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            //Processing
            SameValues(occurrences, numbers);

            //Print result
            Print(occurrences);
        }

        private static void Print(Dictionary<double, int> occurrences)
        {
            foreach (var item in occurrences)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }

        static void SameValues(Dictionary<double, int> occurrences, double[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                double current = numbers[i];

                if (!occurrences.ContainsKey(current))
                {
                    occurrences.Add(current, 0);
                }
                occurrences[current]++;
            }
        }
    }
}
