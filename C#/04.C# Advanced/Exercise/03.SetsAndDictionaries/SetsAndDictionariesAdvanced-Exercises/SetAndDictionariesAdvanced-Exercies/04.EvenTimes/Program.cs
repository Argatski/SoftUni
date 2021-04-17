using System;
using System.Collections.Generic;

namespace _04.EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int rotations = int.Parse(Console.ReadLine());

            Dictionary<int, int> numbers = new Dictionary<int, int>();

            for (int i = 0; i < rotations; i++)
            {
                int currentDigit = int.Parse(Console.ReadLine());

                if (!numbers.ContainsKey(currentDigit))
                {
                    numbers.Add(currentDigit, 0);
                }

                numbers[currentDigit]++;
            }


            foreach (var digit in numbers)
            {
                if (digit.Value % 2 == 0)
                {
                    Console.WriteLine(digit.Key);
                }
            }
        }
    }
}