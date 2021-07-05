using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    class StartUo
    {
        static void Main(string[] args)
        {
            //Numbers of cars
            int number = int.Parse(Console.ReadLine());

            List<Car> listCars = new List<Car>();

            for (int i = 0; i < number; i++)
            {
                string[] carsInfo = Console.ReadLine()
                    .Split();

                string model = carsInfo[0];
                double fuelAmount = double.Parse(carsInfo[1]);
                double fuelConsumptionForKm = double.Parse(carsInfo[2]);

                //A car’s model is unique 
                if (!listCars.Any(c=>c.Model.Contains(model)))
                {
                    Car car = new Car(model, fuelAmount, fuelConsumptionForKm, 0);

                    listCars.Add(car);
                }

            }

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] commandArgs = input.Split();

                string command = commandArgs[0];
                

                if (command =="Drive")
                {
                    string model = commandArgs[1];
                    double amountOfKm = double.Parse(commandArgs[2]);

                    var car = listCars.Where(x => x.Model == model)
                        .FirstOrDefault();

                    car.Drive(amountOfKm);
                }

            }

            foreach (var car in listCars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
