using System;

namespace _05.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            int digits = 0;

            for (int i = 1; i <= numbers; i++)
            {
                int sum = 0;
                digits = i % 10;
                sum += digits;
                digits = i / 10;
                sum += digits;

                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}
