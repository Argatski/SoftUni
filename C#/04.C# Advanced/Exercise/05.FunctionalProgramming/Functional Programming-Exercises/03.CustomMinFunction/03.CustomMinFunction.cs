using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            //Solution
            int result = MinFunction(numbers);

            //Print result

            Console.WriteLine(result);
        }

        static Func<int[], int> MinFunction = n =>
        {
            int minNumber = int.MaxValue;

            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] < minNumber)
                {
                    minNumber = n[i];
                }
            }

            return minNumber;
        };

        /*static void Main(string[] args)
        {
            //Another solution//
            List<int> num = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int first = num.First(n => n < int.MaxValue); 

            Console.WriteLine(first);
        }*/
    }
}
