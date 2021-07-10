using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine()
                    .Split();

                string model = input[0];

                //Engine
                int speed = int.Parse(input[1]);
                int power = int.Parse(input[2]);
                Engine engine = new Engine(speed,power);

                //Cargo
                int weight = int.Parse(input[3]);
                string type = input[4];
                Cargo cargo = new Cargo(weight, type);

                Tire[] tires = new Tire[]
                {
                new Tire (double.Parse(input[5]),int.Parse(input[6])),
                new Tire(  double.Parse(input[7]),int.Parse(input[8])),
                new Tire( double.Parse(input[9]),int.Parse(input[10])),
                new Tire( double.Parse(input[11]),int.Parse(input[12])),
                };

                //Check the car is unique.
                Car car = new Car(model,engine,cargo,tires);
                cars.Add(car);
            }

            string command = Console.ReadLine();

            if (command=="fragile")
            {
                List<Car> result = cars
                    .Where(c => c.Cargo.Type == "fragile")
                    .Where(c => c.Tires.Any(p => p.Pressure < 1)).ToList();


                foreach (var car in result)
                {
                    Console.WriteLine(car);
                }

            }
            else
            {
                List<Car> result = cars
                    .Where(c => c.Cargo.Type == "flamable")
                    .Where(c => c.Engine.Power > 250)
                    .ToList();

                foreach (var car in result)
                {
                    Console.WriteLine(car);
                }
            }
        }
    }
}
