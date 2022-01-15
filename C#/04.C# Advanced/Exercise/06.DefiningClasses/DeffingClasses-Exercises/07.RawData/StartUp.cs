using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //Input
            int number = int.Parse(Console.ReadLine());

            //Create cars list
            List<Car> cars = new List<Car>();

            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = input[0];

                //Engine
                int speed = int.Parse(input[1]);
                int power = int.Parse(input[2]);
                Engine engine = new Engine(speed, power);

                //Cargo
                int weight = int.Parse(input[3]);
                string type = input[4];
                Cargo cargo = new Cargo(weight, type);

                //Tire
                Tire[] tires = new Tire[4]
                {
                    new Tire(double.Parse(input[5]),int.Parse(input[6])),
                    new Tire(double.Parse(input[7]),int.Parse(input[8])),
                    new Tire(double.Parse(input[9]),int.Parse(input[10])),
                    new Tire(double.Parse(input[11]),int.Parse(input[12]))
                };

                //Instance car
                Car car = new Car(name, engine, cargo, tires);

                //Add car in list cars
                cars.Add(car);
            }

            //Processing
            Print(cars);

        }


        /// <summary>
        /// Print type cargo "fragile" or "flammable".
        /// </summary>
        /// <param name="cars"></param>
        /// <returns></returns>
        public static void Print(List<Car> cars)
        {
            string command = Console.ReadLine();

            if (command == "fragile")
            {
                cars = cars
                    .Where(t => t.Cargo.Type == "fragile")
                    .Where(p => p.Tires.Any(p => p.Pressure < 1))
                    .ToList();

                foreach (var car in cars)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                cars = cars
                    .Where(t => t.Cargo.Type == "flammable")
                    .Where(p => p.Engine.Power > 250)
                    .ToList();

                foreach (var car in cars)
                {
                    Console.WriteLine(car);
                }
            }
        }
    }
}


