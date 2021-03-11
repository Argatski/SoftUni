using System;

namespace _01.SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            //Output
            Console.WriteLine(SmallestNumbers(num1, num2, num3));
        }

        //Solution
        private static int SmallestNumbers(int num1, int num2, int num3)
        {
            int currentNum = Math.Min(num1, num2);
            int result = Math.Min(currentNum, num3);

            return result;
        }

    }
}
