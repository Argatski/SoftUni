using System;
using Vehicles.Exceptions;
using Vehicles.Models;

namespace Vehicles.Core
{
    public class Engine
    {
        public void Run()
        {
            string[] carInf = Console.ReadLine()
                .Split();
            double fuel = double.Parse(carInf[1]);
            double litersCar = double.Parse(carInf[2]);
            Vehicle car = new Car(fuel, litersCar);


            string[] truckInf = Console.ReadLine()
                .Split();
            double fuelTruck = double.Parse(truckInf[1]);
            double litersTruck = double.Parse(truckInf[2]);
            Vehicle truck = new Truck(fuelTruck, litersTruck);

            int numCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numCommands; i++)
            {
                try
                {
                    string[] arguments = Console.ReadLine()
                   .Split();

                    string command = arguments[0];
                    string vehicle = arguments[1];


                    switch (command)
                    {
                        case "Drive":
                            double distance = double.Parse(arguments[2]);
                            if (vehicle == "Car")
                            {
                                Console.WriteLine(car.Drive(distance));
                            }
                            else
                            {
                                Console.WriteLine(truck.Drive(distance));
                            }
                            break;
                        case "Refuel":
                            double liters = double.Parse(arguments[2]);

                            if (vehicle == "Truck")
                            {
                                truck.AmountOfFuel(liters);
                            }
                            else
                            {
                                car.AmountOfFuel(liters);
                            }
                            break;
                    }
                }
                catch (LowFuelException ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
        }
    }
}
