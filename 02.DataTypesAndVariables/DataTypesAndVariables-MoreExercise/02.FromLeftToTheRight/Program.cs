using System;

namespace _02.FromLeftToTheRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i < number; i++)
            {
                string receiveNumber = Console.ReadLine();

                string[] splitNumber = receiveNumber.Split(' ');

                long leftNumber = long.Parse(splitNumber[0]);
                long rightNumber = long.Parse(splitNumber[1]);

                long bigNumber = rightNumber;

                if (leftNumber>rightNumber)
                {
                    bigNumber = leftNumber;
                }

                long sumOfdigits = 0;

                while (bigNumber!=0)
                {
                    sumOfdigits += bigNumber%10;
                    bigNumber /= 10;
                }

                Console.WriteLine(Math.Abs(sumOfdigits));
                
            }
        }
    }
}
