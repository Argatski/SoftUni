using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.GaussTrick
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            List<double> numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            //Solution
            SumFirstLast(numbers);
            //Output
            Console.WriteLine(String.Join(" ",SumFirstLast(numbers)));
        }
        static List<double> SumFirstLast(List<double> num)
        {
            List<double> result = new List<double>();

            for (int i = 0; i < num.Count / 2; i++)
            {
                result.Add( num[i] + num[num.Count-1-i]);
                
            }
            if (num.Count%2!=0)
            {
                result.Add(num[num.Count/2]);
            }
            return result;
        }
    }
}
