using System;

namespace _08.FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            //Solution
            decimal firstResult = FirstNumberFactorial(num1);
            decimal secondResult = SecondNumberFactorial(num2);

            //Output    
            decimal result = firstResult/secondResult;
            Console.WriteLine($"{result:F2}");
        }

        //Solution: First Factorial
        static decimal FirstNumberFactorial(decimal number1)
        {
            decimal firstSum = 1;

            for (int i = 1; i <= number1; i++)
            {
                firstSum *= i;
            }

            return firstSum;
        }
        static decimal SecondNumberFactorial(decimal number2)
        {
            decimal secondSum = 1;

            for (int i = 1; i <= number2; i++)
            {
                secondSum *= i;
            }

            return secondSum;
        }

    }
}
