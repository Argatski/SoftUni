using System;

namespace _06.StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int digits = number;
            int sum = 0;

            while (digits != 0)
            {

                int currentSum = 1;
                int currentNumber = digits % 10;
                digits /= 10;

                for (int i = 1; i <= currentNumber; i++)
                {
                    currentSum *= i;
                }

                sum += currentSum;

            }

            if (sum == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
