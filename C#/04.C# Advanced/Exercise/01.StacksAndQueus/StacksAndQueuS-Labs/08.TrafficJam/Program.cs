using System;
using System.Collections.Generic;

namespace _08.TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int numberCars = int.Parse(Console.ReadLine());

            string arg = string.Empty;

            Queue<string> cars = new Queue<string>();

            int count = 0;

            while ((arg = Console.ReadLine()) != "end")
            {

                if (arg == "green")
                {
                    if (cars.Count < numberCars)
                    {
                        numberCars = cars.Count;
                    }
                    for (int i = 0; i < numberCars; i++)
                    {
                        Console.WriteLine($"{cars.Dequeue()} passed!");
                        count++;
                    }
                }
                else
                {
                    cars.Enqueue(arg);
                }
            }

            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
