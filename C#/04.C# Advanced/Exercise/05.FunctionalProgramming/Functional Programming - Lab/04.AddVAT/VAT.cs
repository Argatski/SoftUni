using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.AddVAT
{
    class VAT
    {
        static void Main(string[] args)
        {
            //Input
            double[] prices = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                //.Select(Parser)
                //.Select(double.Parse)
                .Select(DoubleParser)
                .Select(AddVAT)
                //.Select(VAT2)
                //.Select(d => d * 1.20)
                .ToArray();

            //Print number
            foreach (var num in prices)
            {
                Console.WriteLine($"{num:f2}");
            }

        }

        /// <summary>
        /// The function converts the string to a double number.
        /// </summary>
        public static Func<string, double> Parser = d => double.Parse(d);

        /// <summary>
        /// The function converts the string to a double number.
        /// </summary>
        public static Func<string, double> DoubleParser = d =>
        {
            double result = 0;
            if (double.TryParse(d, out result))
            {
                return result;
            }
            return result;
        };

        /// <summary>
        /// The funciton added VAT for all numbers of them.
        /// </summary>
        public static Func<double, double> AddVAT = v => v * 1.20;

        /// <summary>
        /// The funciton added VAT for all numbers of them.
        /// </summary>
        public static Func<double, double> VAT2 = v =>
        {
            return v * 1.2;
        };


    }
}

//Another solution
/*
 *  static void Main(string[] args)
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
 */
