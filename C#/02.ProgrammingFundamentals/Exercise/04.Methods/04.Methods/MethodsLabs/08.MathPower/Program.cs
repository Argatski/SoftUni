using System;

namespace _08.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            double number = double.Parse(Console.ReadLine());
            double powerNum = double.Parse(Console.ReadLine());

            //Output
            MathPower(number, powerNum);
            double result = MathPower(number, powerNum);
            Console.WriteLine(result);
        }

        //Solution
        static double MathPower(double num, double pow) 
        {
            double calc = Math.Pow(num, pow);
            return calc;
           
        }
    }
}
