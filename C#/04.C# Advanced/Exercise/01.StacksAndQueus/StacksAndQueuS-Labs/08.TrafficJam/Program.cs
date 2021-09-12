using System;
using System.Collections.Generic;

namespace _08.TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int carsPass = int.Parse(Console.ReadLine());

            Queue<string> traffic = new Queue<string>();

            //Proccesing
            string command = "";

            int countCarsPass = 0;

            while ((command = Console.ReadLine()) != "end")
            {
                if (command == "green")
                {
                    for (int i = 0; i < carsPass; i++)
                    {
                        if (traffic.Count > 0)
                        {
                            //Cars passed
                            Console.WriteLine(traffic.Dequeue() + " passed!");
                            countCarsPass++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else
                {
                    traffic.Enqueue(command);
                }
            }

            //Print numbers of cars passed the crossroads.
            Console.WriteLine($"{countCarsPass} cars passed the crossroads.");
        }
    }


    /* Another solution
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
           */
}
