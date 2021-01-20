using System;

namespace _07.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int interval = int.Parse(Console.ReadLine());
            int waterTank = 255;

            int sum = 0;
            string rezult = string.Empty;

            for (int i = 0; i < interval; i++)
            {
                int litres = int.Parse(Console.ReadLine());

                if (waterTank >= litres)
                {
                    sum += litres;
                    if (sum>waterTank)
                    {
                        Console.WriteLine($"Insufficient capacity!");
                        sum -= litres;
                    }
                }
                else
                {
                    Console.WriteLine($"Insufficient capacity!");
                }
            }
            Console.WriteLine($"{sum}");
        }
    }
}
