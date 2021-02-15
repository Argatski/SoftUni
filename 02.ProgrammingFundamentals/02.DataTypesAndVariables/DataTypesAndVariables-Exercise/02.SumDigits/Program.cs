using System;

namespace _02.SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int digits = 0;
            int sum = 0;

            while (number!=0)
            {
                digits = number % 10;
                sum += digits;
                number /= 10;
            }

            Console.WriteLine(sum);
        }
    }
}
