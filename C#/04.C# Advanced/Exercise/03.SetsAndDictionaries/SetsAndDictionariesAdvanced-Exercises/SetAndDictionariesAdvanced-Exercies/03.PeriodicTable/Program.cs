using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int n = int.Parse(Console.ReadLine());

            HashSet<string> chemicalCompaounds = new HashSet<string>();

            //Processing unique chemical elements
            Processing(n, chemicalCompaounds);

            //Print elements
            Print(chemicalCompaounds);
        }

        static void Print(HashSet<string> chemicalCompaounds)
        {
            foreach (var element in chemicalCompaounds.OrderBy(x => x))
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }

        private static void Processing(int n, HashSet<string> chemicalCompaounds)
        {
            for (int i = 0; i < n; i++)
            {
                string[] elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int e = 0; e < elements.Length; e++)
                {
                    chemicalCompaounds.Add(elements[e]);
                }

            }
        }
    }
}
