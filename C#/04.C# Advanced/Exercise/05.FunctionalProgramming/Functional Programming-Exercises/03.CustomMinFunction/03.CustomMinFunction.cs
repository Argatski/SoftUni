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
            List<int> numbers = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList();

            //Solution
            int minFistNum = MinFunction(numbers);

            //Print result min value
            Console.WriteLine(minFistNum);
        }

        /// <summary>
        /// The function looks for a minimum value in an array.
        /// </summary>
        private static Func<List<int>, int> MinFunction = n =>
         {
             int minNumber = int.MaxValue;

             for (int i = 0; i < n.Count; i++)
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
