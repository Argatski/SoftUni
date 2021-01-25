using System;
using System.Collections.Generic;

namespace _04.RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            AddCarInList(cars);
            PrintOutput(cars);
        }

        private static void PrintOutput(List<Car> cars)
        {
            string command = Console.ReadLine();

            switch (command)
            {
                case "fragile":
                    List<Car> fragileCars = cars.FindAll(x => x.Cargo.Type == command && x.Cargo.Weight < 1000);
                    foreach (Car model in fragileCars)
                    {
                        Console.WriteLine(model.Model);
                    }
                    break;
                case "flamable":
                    List<Car> flamableCars = cars.FindAll(x => x.Cargo.Type == command && x.Engine.Power > 250);
                    foreach (Car model in flamableCars)
                    {
                        Console.WriteLine(model.Model);
                    }

                    break;
            }
        }

        static void AddCarInList(List<Car> cars)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string[] args = Console.ReadLine().Split();
                string model = args[0];
                int speed = int.Parse(args[1]);
                int power = int.Parse(args[2]);
                int weight = int.Parse(args[3]);
                string type = args[4];

                Engine engine = new Engine(speed, power);
                Cargo cargo = new Cargo(weight, type);
                Car car = new Car(model, engine, cargo);

                cars.Add(car);
            }
        }

        //class Car
        //{
        //    public string Model { get; set; }
        //    public Engine Engine { get; set; }
        //    public Cargo Cargo { get; set; }

        //    public Car(string model, Engine engine, Cargo cargo)
        //    {
        //        Model = model;
        //        Engine = engine;
        //        Cargo = cargo;
        //    }

        //}

        //class Cargo
        //{
        //    public int Weight { get; set; }
        //    public string Type { get; set; }

        //    public Cargo(int weight, string type)
        //    {
        //        Weight = weight;
        //        Type = type;
        //    }
        //}

        //class Engine
        //{
        //    public int Speed { get; set; }
        //    public int Power { get; set; }

        //    public Engine(int speed, int power)
        //    {
        //        Speed = speed;
        //        Power = power;
        //    }
        //}

    }

}
