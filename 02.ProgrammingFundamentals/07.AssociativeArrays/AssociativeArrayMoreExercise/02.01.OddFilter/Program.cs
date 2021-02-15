using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._01.OddFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            List<int> oddNumbers = numbers.Where(n => n % 2 == 0).ToList();

            double sum = oddNumbers.Average();

            List<int> resultNumbers = new List<int>();

            foreach (var item in oddNumbers)
            {
                int result =  item > sum ? item + 1 : item - 1;

                resultNumbers.Add(result);
            }

            Console.WriteLine(string.Join(" ",resultNumbers));
        }
    }
}
