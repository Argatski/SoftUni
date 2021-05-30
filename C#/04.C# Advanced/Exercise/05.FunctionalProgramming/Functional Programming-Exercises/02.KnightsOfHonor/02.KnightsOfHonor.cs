using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            List<string> names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            //Print result
            PrintResult(names);

        }
        static Action<List<string>> PrintResult = n =>
             {
                 //Lambda exprecions 
                 n.ForEach(n => Console.WriteLine($"Sir {n}"));
             };
    }
}
