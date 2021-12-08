using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.KnightsOfHonor
{
    class PrintSirName
    {
        static void Main(string[] args)
        {
            //Input 
            List<string> names = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .ToList();

            //Print result
            PrintSir(names);

        }

        /// <summary>
        /// The action appends the word "Sir" and prints a new word.
        /// </summary>
        public static Action<List<string>> PrintSir = n =>
            {
                n.ForEach(n => Console.WriteLine($"Sir {n}"));
            };
        
    }
}

