using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.NeedForSpeed
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int numberOfCars = int.Parse(Console.ReadLine());

            //Input car in catalog
            var carsCatalog = InputCatalog(numberOfCars);

            //Processing
            Processing(carsCatalog);


        }

        static void Processing(Dictionary<string, List<int>> carsCatalog)
        {
            string arg;

            while ((arg = Console.ReadLine()) != "Stop")
            {
                string[] input = arg.Split(" : ");

                string command = input[0];

                switch (command)
                {
                    case "Drive":
                        Drive(input, carsCatalog);
                        break;
                    case "Refuel":
                        Refuel(input, carsCatalog);
                        break;
                    case "Revert":
                        ReverstCars(input, carsCatalog);
                        break;
                }
            }

            PrintCatalog(carsCatalog);
        }

        static void PrintCatalog(Dictionary<string, List<int>> carsCatalog)
        {
            carsCatalog = carsCatalog
                .OrderByDescending(v => v.Value[0])
                .ThenBy(k => k.Key)
                .ToDictionary(k => k.Key, v => v.Value);

            foreach (var name in carsCatalog)
            {
                Console.WriteLine($"{name.Key} -> Mileage: {name.Value[0]} kms, Fuel in the tank: {name.Value[1]} lt.");
            }
        }

        static void ReverstCars(string[] input, Dictionary<string, List<int>> carsCatalog)
        {
            string name = input[1];
            int kilometers = int.Parse(input[2]);

            int mileage = carsCatalog[name][0];

            //Use elvis operators
            int revertMileage = mileage - kilometers > 10000 ? mileage - kilometers : 10000;

            if (mileage - kilometers > 10000)
            {
                Console.WriteLine($"{name} mileage decreased by {kilometers} kilometers");
            }

            carsCatalog[name][0] = revertMileage;

        }

        private static void Refuel(string[] input, Dictionary<string, List<int>> carsCatalog)
        {
            string name = input[1];
            int fuel = int.Parse(input[2]);

            int currentFuel = carsCatalog[name][1];

            //Elvis (conditional operators)
            int result = currentFuel + fuel > 75 ? 75 - currentFuel : fuel;

            Console.WriteLine($"{name} refueled with {result} liters");

            if (currentFuel + fuel > 75)
            {
                carsCatalog[name][1] = 75;
            }
            else
            {
                carsCatalog[name][1] = fuel + currentFuel; ;
            }


        }

        static void Drive(string[] input, Dictionary<string, List<int>> carsCatalog)
        {
            string nameCar = input[1];
            int distance = int.Parse(input[2]);
            int fuel = int.Parse(input[3]);

            if (carsCatalog[nameCar][1] < fuel)
            {
                Console.WriteLine("Not enough fuel to make that ride");
            }
            else
            {
                carsCatalog[nameCar][0] += distance;
                carsCatalog[nameCar][1] -= fuel;

                Console.WriteLine($"{nameCar} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                if (carsCatalog[nameCar][0] >= 100000)
                {
                    Console.WriteLine($"Time to sell the {nameCar}!");
                    carsCatalog.Remove(nameCar);
                }
            }
        }

        static Dictionary<string, List<int>> InputCatalog(int numberOfCars)
        {
            Dictionary<string, List<int>> cars = new Dictionary<string, List<int>>();
            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carsThemselves = Console.ReadLine()
                    .Split("|");

                string name = carsThemselves[0];
                int mileage = int.Parse(carsThemselves[1]);
                int fuel = int.Parse(carsThemselves[2]);

                if (!cars.ContainsKey(name))
                {
                    cars.Add(name, new List<int>() { mileage, fuel });
                }

            }
            return cars;
        }
    }
}
