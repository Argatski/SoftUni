using System;

namespace _11.MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            double num1 = double.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            double num2 = double.Parse(Console.ReadLine());

            //Output
            double result = Calculate(num1, num2, @operator);
            Console.WriteLine($"{result:f0}");

        }

        static double Calculate(double num1, double num2, string @operator)
        {
            double calc = 0;

            switch (@operator)
            {
                case "*":
                    calc = num1 * num2;
                    break;
                case "/":
                    calc = num1 / num2;
                    break;
                case "+":
                    calc = num1 + num2;
                    break;
                case "-":
                    calc = num1 - num2;
                    break;
            }
            return calc;
        }
    }
}
