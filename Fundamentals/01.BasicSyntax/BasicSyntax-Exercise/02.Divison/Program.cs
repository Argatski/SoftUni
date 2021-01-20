using System;

namespace _02.Divison
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int divison = 0;

            if (inputNumber%2==0)
            {
                divison = 2;
            }
            if (inputNumber%3==0)
            {
                divison = 3;
            }
            if (inputNumber % 6 == 0)
            {
                divison = 6;
            }
            if (inputNumber % 7 == 0)
            {
                divison = 7;
            }
            if (inputNumber % 10== 0)
            {
                divison = 10;
            }
            if (divison==0)
            {
                Console.WriteLine("Not divisible");
                return;
            }

            Console.WriteLine($"The number is divisible by {divison}");

        }
    }
}
