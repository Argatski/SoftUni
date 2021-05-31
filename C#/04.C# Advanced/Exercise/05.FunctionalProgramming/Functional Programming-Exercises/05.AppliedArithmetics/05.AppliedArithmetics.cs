using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            //Processing
            Processing(numbers);
        }

        static void Processing(List<int> numbers)
        {
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                if (command == "add")
                {
                     Add(numbers);
                }
                else if (command == "multiply")
                {
                     Multiply(numbers);
                }
                else if (command == "subtract")
                {
                     Subtract(numbers);
                }
                else if (command == "print")
                {
                    Print(numbers);
                }
            }
        }
        /* Another type of Funcitonal
        public static Func<List<int>, List<int>> Add = a => a.Select(a => a + 1).ToList();
        public static Func<List<int>, List<int>> Multiply = m => m.Select(m =>m * 2).ToList();
        public static Func<List<int>, List<int>> Subtract = s => s.Select(s => s + 1).ToList();
        public static Func<List<int>, List<int>> Print = p => string.Join(" ",p);
        */

        public static Func<List<int>, List<int>> Add = x =>
         {
             for (int i = 0; i < x.Count; i++)
             {
                 x[i] += 1;
             }
             return x;
         };

        public static Func<List<int>, List<int>> Multiply = m =>
        {
            for (int i = 0; i < m.Count; i++)
            {
                m[i] *= 2;
            }
            return m;
        };

        public static Func<List<int>, List<int>> Subtract = s =>
        {
            for (int i = 0; i < s.Count; i++)
            {
                s[i] -= 1;
            }

            return s;
        };

        public static Action<List<int>> Print = p =>
        {
            Console.WriteLine(string.Join(" ", p));
        };
    }
}
