using System;
using System.Linq;

namespace _08.CustomComparator
{
    class CustomComparator
    {
        static void Main(string[] args)
        {
            //Input 
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            //Solution sort and filtter
            Array.Sort(numbers, (x, y) => filtterEven(x, y));

            //Print
            Console.WriteLine(string.Join(" ", numbers));

        }

        /// <summary>
        /// The function selects every number that is an even.
        /// </summary>
        public static Func<int, int, int> filtterEven = (x, y) => Math.Abs(x % 2) == Math.Abs(y % 2) ? (x == y ? 0 : (x < y ? -1 : 1)) : (Math.Abs(x % 2) == 0 ? -1 : 1);

    }
}