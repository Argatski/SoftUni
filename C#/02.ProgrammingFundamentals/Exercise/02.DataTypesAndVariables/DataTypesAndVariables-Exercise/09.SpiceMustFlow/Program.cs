using System;

namespace _09.SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int totalAmount = 0;
            int day = 0;
            int mining = 0;
            if (startingYield >= 100)
            {
                while (startingYield >= 100)
                {
                    mining = startingYield - 26;
                    startingYield -= 10;
                    totalAmount += mining;
                    day++;

                }
                totalAmount -= 26;
                Console.WriteLine($"{day}");
                Console.WriteLine($"{totalAmount}");
            }
            else
            {
                Console.WriteLine($"{day}");
                Console.WriteLine($"{totalAmount}");
            }
        }
    }
}
