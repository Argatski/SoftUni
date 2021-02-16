using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._01.Sum_Min_Max_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int count = int.Parse(Console.ReadLine());

            List<double> numbers = new List<double>();

            //Solution
            ArrayNumbers(count, numbers);

            SumNumbers(numbers);
            MinNumber(numbers);
            MaxNumber(numbers);
            AverageNumber(numbers);
        }

        static void AverageNumber(List<double> numbers)
        {
            double avarage = numbers.Average();
            Console.WriteLine($"Average = {avarage}");
        }

        static void MaxNumber(List<double> numbers)
        {
            double maxNum = numbers.Max();
            Console.WriteLine($"Max = {maxNum}");
        }

        static void MinNumber(List<double> numbers)
        {
            double minNum = numbers.Min();
            Console.WriteLine($"Min = {minNum}");
        }

        static void SumNumbers(List<double> numbers)
        {
            double sum = numbers.Sum();
            Console.WriteLine($"Sum = {sum}");
        }

        static List<double> ArrayNumbers(int count, List<double> num)
        {
            for (int i = 0; i < count; i++)
            {
                double n = double.Parse(Console.ReadLine());
                num.Add(n);
            }
            return num;
        }
    }
}
