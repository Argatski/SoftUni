using System;
using System.Linq;
namespace _03.RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //read array type integer//
            double[] number = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            for (int i =0 ; i <= number.Length-1; i++)
            {
                double currentNumber = number[i];
                currentNumber =(int) Math.Round(currentNumber, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{number[i]} => {currentNumber}");
            }

            //foreach (var current in number)
            //{
            //    int rounded = (int)Math.Round(current, MidpointRounding.AwayFromZero);
            //    Console.WriteLine($"{current} => {rounded}");
            //}

        }
    }
}
