using System;
using System.Collections.Generic;

namespace _03.SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Car> cars =AddingCarToList();

            //Solution
            Proccessing(cars);

            Console.WriteLine(string.Join(Environment.NewLine, cars));
        }

        static void Proccessing(List<Car> cars)
        {
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] args = command.Split(" ");
                string carModel = args[1];
                double amountOfKM = double.Parse(args[2]);

                Car currentCar = cars.Find(m => m.Model == carModel);

                bool canTravelDistance = currentCar.Calculate(amountOfKM, currentCar);

                if (canTravelDistance)
                {
                    currentCar.TraveDistance += amountOfKM;
                    currentCar.FuelAmount -= amountOfKM * currentCar.FuelConsumation;
                }
                else
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }

            }
        }

        static List<Car> AddingCarToList()
        {
            List<Car> list = new List<Car>();

            int carCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < carCount; i++)
            {
                string[] carArgs = Console.ReadLine().Split(" ");
                string model = carArgs[0];
                double fuelAmount = double.Parse(carArgs[1]);
                double consumationForKM = double.Parse(carArgs[2]);

                Car car = new Car(model, fuelAmount, consumationForKM, 0);

                list.Add(car);
            }

            return list;
        }
        class Car
        {
            public string Model { get; set; }
            public double FuelAmount { get; set; }
            public double FuelConsumation { get; set; }
            public double TraveDistance { get; set; }

            public Car(string model, double fuel, double consumation, double distance)
            {
                Model = model;
                FuelAmount = fuel;
                FuelConsumation = consumation;
                TraveDistance = distance;
            }
            /// <summary>
            /// Chek the fuel is enough
            /// </summary>
            /// <param name="distance"></param>
            /// <param name="car"></param>
            /// <returns></returns>
            public bool Calculate(double distance, Car car)
            {
                double fuelNeeded = distance * car.FuelConsumation;
                if (fuelNeeded <= car.FuelAmount)
                {
                    return true;
                }
                return false;
            }

            public override string ToString()
            {
                return $"{Model} {FuelAmount:F2} {TraveDistance}";
            }
        }


    }
}
