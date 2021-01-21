using System;
using System.IO;
using System.Reflection.Metadata.Ecma335;

namespace _01.SignOfIntegerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int number = int.Parse(Console.ReadLine());
            //Print
            PrintSignNumber(number);

        }

        //Solution with method
        //static void PrintSignNumber(int num)
        //{
        //    if (num > 0)
        //    {
        //        Console.WriteLine($"The number {num} is positive.");
        //    }
        //    else if (num < 0)
        //    {
        //        Console.WriteLine($"The number {num} is negative.");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"The number {num} is zero.");
        //    }
        //}

        // Another solution
        static void PrintSignNumber(int num)
        {
            Positive(num);
            Negative(num);
            Zero(num);
        }

        private static void Zero(int num)
        {

            if (num == 0)
            {
                Console.WriteLine($"The number {num} is zero.");
                
            }
        }

        private static void Negative(int num)
        {
            if (num < 0)
            {
                Console.WriteLine($"The number {num} is negative.");
            }

        }

        private static void Positive(int num)
        {
            if (num > 0)
            {
                Console.WriteLine($"The number {num} is positive.");
               
            }

        }
    }
}
