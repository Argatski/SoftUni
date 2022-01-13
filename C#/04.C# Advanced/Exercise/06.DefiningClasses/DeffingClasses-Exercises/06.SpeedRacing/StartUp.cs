using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //Numbers of cars
            int number = int.Parse(Console.ReadLine());

            //Instance cars
            List<Car> cars = new List<Car>();


            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                double fuelAmount = double.Parse(input[1]);
                double perKilometer = double.Parse(input[2]);

                //Instance car
                Car car = new Car(model, fuelAmount, perKilometer, 0);
                cars.Add(car);
            }

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] input = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "Drive")
                {
                    string model = input[1];
                    double amountOfKm = double.Parse(input[2]);

                    Car currentCar = cars.Where(m => m.Model == model).FirstOrDefault();

                    currentCar.Drive(amountOfKm);
                }
            }

            //Print result
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
