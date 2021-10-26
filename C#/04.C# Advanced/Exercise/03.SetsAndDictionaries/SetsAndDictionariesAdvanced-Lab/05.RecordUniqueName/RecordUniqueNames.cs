using System;
using System.Collections.Generic;

namespace _05.RecordUniqueName
{
    class RecordUniqueNames
    {
        static void Main(string[] args)
        {
            //Input
            int number = int.Parse(Console.ReadLine());

            HashSet<string> names = new HashSet<string>();

            //Processing
            Processing(number, names);

            //Print unique names
            Print(names);
        }

        /// <summary>
        /// Print unique names
        /// </summary>
        /// <param name="names"></param>
        private static void Print(HashSet<string> names)
        {
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }

        /// <summary>
        /// Create list with unique names
        /// </summary>
        /// <param name="n"></param>
        /// <param name="names"></param>
        static void Processing(int n, HashSet<string> names)
        {
            //Create list with unique names
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();

                names.Add(name);
            }
        }
    }
}

