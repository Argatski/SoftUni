using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //Instace
            List<Tire[]> tires = new List<Tire[]>();
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            //Input data Tires in class
            string command;
            while ((command = Console.ReadLine()) != "No more tires")
            {
                string[] parameters = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var currentTires = new Tire[4]
                    {
                        new Tire(int.Parse(parameters[0]),double.Parse(parameters[1])),
                        new Tire(int.Parse(parameters[2]),double.Parse(parameters[3])),
                        new Tire(int.Parse(parameters[4]),double.Parse(parameters[5])),
                        new Tire(int.Parse(parameters[6]),double.Parse(parameters[7])),
                    };
                tires.Add(currentTires);
            }

            //Instace Engine
            while ((command = Console.ReadLine()) != "Engines done")
            {
                string[] parameteres = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                int horsePower = int.Parse(parameteres[0]);
                double cubicCapacity = double.Parse(parameteres[1]);

                Engine engine = new Engine(horsePower, cubicCapacity);
                engines.Add(engine);
            }
            //Instance car
            while ((command = Console.ReadLine()) != "Show special")
            {
                string[] parameteres = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = parameteres[0];
                string model = parameteres[1];
                int year = int.Parse(parameteres[2]);
                double fuelQuantity = double.Parse(parameteres[3]);
                double fuelConsumption = double.Parse(parameteres[4]);


                int engineIndex = int.Parse(parameteres[5]);
                int tireIndex = int.Parse(parameteres[6]);

                Car car = new Car(name, model, year, fuelQuantity, fuelConsumption, tires[tireIndex], engines[engineIndex]);

                //All car drive 20 kilometeres.
                car.Drive(20);

                cars.Add(car);
            }


            //Show me special Car
            //Print Result
            string specialCar = GetSpecialCar(cars);

            Console.WriteLine(specialCar);

        }

        private static string GetSpecialCar(List<Car> cars)
        {
            List<Car> specialCar = cars
                .Where(y => y.Year >= 2017)
                .Where(h => h.Engine.HorsePower >= 330)
                .Where(p => p.Tires.Sum(a => a.Pressure) >= 9 && p.Tires.Sum(z => z.Pressure) <= 10)
                .ToList();
            StringBuilder sb = new StringBuilder();

            foreach (var car in specialCar)
            {
                sb.AppendLine($"Make: {car.Make}");
                sb.AppendLine($"Model: {car.Model}");
                sb.AppendLine($"Year: {car.Year}");
                sb.AppendLine($"HorsePowers: {car.Engine.HorsePower}");
                sb.AppendLine($"FuelQuantity: {car.FuelQuantity}");
            }

            return sb.ToString();
        }
    }
}

