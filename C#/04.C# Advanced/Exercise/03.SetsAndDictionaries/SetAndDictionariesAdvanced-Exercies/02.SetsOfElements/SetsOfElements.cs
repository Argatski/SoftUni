using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SetsOfElements
{
    class SetsOfElements
    {
        static void Main(string[] args)
        {
            //Input
            int[] number = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            //Add "n" set in dictionary
            int n = number[0];

            HashSet<int> nSet = new HashSet<int>();

            //Add number in Hashset
            int m = number[1];

            HashSet<int> mSet = new HashSet<int>();

            //Add number in Hashset
            Add(n, nSet);
            Add(m, mSet);

            //Intersect "n" to "m".
            nSet.IntersectWith(mSet);

            //Print result
            Console.WriteLine(string.Join(" ", nSet));
        }

        /// <summary>
        /// Create hashset
        /// </summary>
        /// <param name="n"></param>
        /// <param name="nSet"></param>
        static void Add(int num, HashSet<int> nSet)
        {
            for (int i = 0; i < num; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                nSet.Add(currentNumber);
            }
        }
    }
}

