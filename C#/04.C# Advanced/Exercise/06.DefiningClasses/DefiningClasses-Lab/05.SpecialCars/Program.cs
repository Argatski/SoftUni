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
            //Instant
            List<Tire[]> tires = new List<Tire[]>();
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            //Input data Tires in class
            // Cheked this not work 
            string command;

            while ((command = Console.ReadLine()) != "No more tires")
            {
                string[] parameters = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                var currentTire = new Tire[4]
                     {
                    new Tire(int.Parse(parameters[0]), double.Parse(parameters[1])),
                    new Tire(int.Parse(parameters[2]), double.Parse(parameters[3])),
                    new Tire(int.Parse(parameters[4]), double.Parse(parameters[5])),
                    new Tire(int.Parse(parameters[6]), double.Parse(parameters[7])),
                     };

                tires.Add(currentTire);
            }

            //Instant Engines
            while ((command = Console.ReadLine()) != "Engines done")
            {
                string[] parameters = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                int horsePower = int.Parse(parameters[0]);

                double cubicCapacity = double.Parse(parameters[1]);

                Engine engine = new Engine(horsePower, cubicCapacity);

                engines.Add(engine);

            }

            //Instant new car
            while ((command = Console.ReadLine()) != "Show special")
            {
                string[] parameters = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string make = parameters[0];
                string model = parameters[1];
                int year = int.Parse(parameters[2]);
                double fuelQuantity = double.Parse(parameters[3]);
                double fuelConsumption = double.Parse(parameters[4]);

                int engineIndex = int.Parse(parameters[5]);
                int tiresIndex = int.Parse(parameters[6]);

                Car car = new Car(make, model, year, fuelQuantity, fuelConsumption, engines[engineIndex], tires[tiresIndex]);

                cars.Add(car);

            }

            string result = GetSpecialCar(cars);

            Console.WriteLine(result);

        }

        private static string GetSpecialCar(List<Car> cars)
        {
            List<Car> specialCars = cars
                .Where(y => y.Year >= 2014)
                .Where(x => x.Engine.HorsePower > 300)
                .Where(x => x.Tires.Sum(y => y.Pressure) >= 9 && x.Tires.Sum(y => y.Pressure) <= 10)
                .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var car in specialCars)
            {
                car.Drive(20);

                sb.AppendLine(car.Make);
                sb.AppendLine(car.Model);
                sb.AppendLine(car.Year.ToString());
                sb.AppendLine(car.Engine.HorsePower.ToString());
                sb.AppendLine(car.FuelQuantity.ToString());
            }

            return sb.ToString();
        }
    }
}
