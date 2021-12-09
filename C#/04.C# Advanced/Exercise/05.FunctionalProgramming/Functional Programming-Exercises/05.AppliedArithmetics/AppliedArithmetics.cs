using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.AppliedArithmetics
{
    class AppliedArithmetics
    {
        static void Main(string[] args)
        {
            //Input
            List<int> number = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            //Processing
            Processing(number);
        }

        private static void Processing(List<int> number)
        {
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {

                switch (command)
                {
                    case "add":
                        number = AddOne(number);
                        break;
                    case "multiply":
                        number = MultiplyNumbers(number);
                        break;
                    case "subtract":
                        number = SubtractOne(number);
                        break;
                    case "print":
                        PrintNum(number);
                        break;
                }
            }
        }
        
        /// <summary>
        /// The function adds one to each number in list of numbers.
        /// </summary>
        public static Func<List<int>, List<int>> Add = n =>
         {
             for (int i = 0; i < n.Count; i++)
             {
                 n[i] += 1;
             }
             return n;
         };

        /// <summary>
        /// The function adds one to each number in list of numbers.(Another way)
        /// </summary>
        public static Func<List<int>, List<int>> AddOne = x => x.Select(y => y + 1).ToList();


        /// <summary>
        /// The function multiply each number in list of numbers.
        /// </summary>
        public static Func<List<int>, List<int>> Multiply = n =>
         {
             for (int i = 0; i < n.Count; i++)
             {
                 n[i] *= 2;
             }

             return n;
         };
        /// <summary>
        /// The function multiply each number in list of numbers.(Another way)
        /// </summary>
        public static Func<List<int>, List<int>> MultiplyNumbers = n => n.Select(m => m *= 2).ToList();

        /// <summary>
        /// The function subtract 1 form each number in list of numbers.
        /// </summary>
        public static Func<List<int>, List<int>> Subtract = n =>
          {
              for (int i = 0; i < n.Count; i++)
              {
                  n[i] -= 1;
              }
              return n;
          };
        /// <summary>
        /// The function subtract 1 form each number in list of numbers.(Another way)
        /// </summary>
        public static Func<List<int>, List<int>> SubtractOne = n => n.Select(s => s -= 1).ToList();

        /// <summary>
        /// The function print the collection.
        /// </summary>
        public static Action<List<int>> Print = p =>
        {
            Console.WriteLine(string.Join(" ", p));
        };
        /// <summary>
        /// The function print the collection.(Another way)
        /// </summary>
        public static Action<List<int>> PrintNum = p => Console.WriteLine(string.Join(" ", p));
    }
}
