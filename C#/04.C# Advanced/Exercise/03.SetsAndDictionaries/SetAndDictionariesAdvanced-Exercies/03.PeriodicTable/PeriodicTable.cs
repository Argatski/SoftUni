using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PeriodicTable
{
    class PeriodicTable
    {
        static void Main(string[] args)
        {
            //Input 
            int n = int.Parse(Console.ReadLine());

            HashSet<string> chemicalCompaounds = new HashSet<string>();

            //Add unique chemicals elements
            Add(n, chemicalCompaounds);

            //Print periodic table
            Print(chemicalCompaounds);
        }

        /// <summary>
        /// Print periodic table in ascending order
        /// </summary>
        /// <param name="chemicalCompaounds"></param>
        private static void Print(HashSet<string> chemicalCompaounds)
        {
            chemicalCompaounds = chemicalCompaounds.OrderBy(e => e).ToHashSet();

            Console.WriteLine(string.Join(" ", chemicalCompaounds));
        }

        /// <summary>
        /// Add unique elements in hashset
        /// </summary>
        /// <param name="n"></param>
        /// <param name="chemicalCompaounds"></param>
        static void Add(int n, HashSet<string> chemicalCompaounds)
        {
            for (int i = 0; i < n; i++)
            {
                string[] elements = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);


                for (int e = 0; e < elements.Length; e++)
                {
                    chemicalCompaounds.Add(elements[e]);
                }
            }
        }
    }
}

