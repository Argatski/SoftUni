using System;

namespace _05.AddAndSubstract
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            //Output
            int sumFirstSecond = Sum(firstNum, secondNum);
            int result = Subtract(sumFirstSecond, thirdNum);

            Console.WriteLine(result);
        }

        private static int Subtract(int sum, int thirdNum)
        {
            int subtract = sum - thirdNum;
            return subtract;
        }

        static int Sum(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }
    }
}
