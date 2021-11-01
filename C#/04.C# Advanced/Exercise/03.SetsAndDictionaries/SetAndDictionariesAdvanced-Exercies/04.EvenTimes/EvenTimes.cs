using System;
using System.Collections.Generic;

namespace _04.EvenTimes
{
    class EvenTimes
    {
        static void Main(string[] args)
        {
            //Input
            int n = int.Parse(Console.ReadLine());

            Dictionary<int, int> numbers = new Dictionary<int, int>();

            //Processing
            Processing(n, numbers);

            //Print
            Print(numbers);
        }

        /// <summary>
        /// Print even times number.
        /// </summary>
        /// <param name="numbers"></param>
        static void Print(Dictionary<int, int> numbers)
        {
            foreach (var num in numbers)
            {
                if (num.Value % 2 == 0)
                {
                    Console.WriteLine(num.Key);
                }
            }
        }

        /// <summary>
        /// Create dicitionary with numbers.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="numbers"></param>
        private static void Processing(int n, Dictionary<int, int> numbers)
        {
            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (numbers.ContainsKey(currentNumber) == false)
                {
                    numbers.Add(currentNumber, 0);
                }

                numbers[currentNumber]++;
            }
        }
    }
}

