using System;

namespace _01.NationalCourt
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int firstEmployee = int.Parse(Console.ReadLine());
            int secondEmployee = int.Parse(Console.ReadLine());
            int thirdEmployee = int.Parse(Console.ReadLine());
            int peopleCount = int.Parse(Console.ReadLine());

            //Solution
            int peoplePerHour = firstEmployee + secondEmployee + thirdEmployee;
            int hours = 0;
            while (peopleCount > 0)
            {
                hours++;
                if (hours % 4 == 0)
                {
                    continue;
                }
                peopleCount -= peoplePerHour;
            }
            //Print rezult
            Console.WriteLine($"Time needed: {hours}h.");

        }
    }
}
