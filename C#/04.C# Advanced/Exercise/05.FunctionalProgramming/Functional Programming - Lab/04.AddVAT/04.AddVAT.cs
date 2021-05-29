using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            Console.ReadLine()
                 .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                 //.Select(double.Parse)
                 //.Select(p => p * 1.20)
                 .Select(Parser)
                 .Select(AddVAT)
                 .ToList()
                 .ForEach(p => Console.WriteLine($"{p:f2}"));

        }
        public static Func<string, double> Parser = p => double.Parse(p);
        public static Func<double, double> AddVAT = p =>
        {
            return p *= 1.20;
        };
    }
}
