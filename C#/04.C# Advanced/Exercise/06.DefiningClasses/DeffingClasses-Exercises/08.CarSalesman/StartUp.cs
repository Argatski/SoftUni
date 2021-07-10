using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //Input engines
            int numberOfEngines = int.Parse(Console.ReadLine());

            List<Engine> engines = new List<Engine>();

            for (int i = 0; i < numberOfEngines; i++)
            {
                string[] arguments = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = arguments[0];
                int power = int.Parse(arguments[1]);

                if (arguments.Length == 2)
                {
                    engines.Add(new Engine(model, power));
                }
                else if (arguments.Length == 3)
                {

                    if (int.TryParse(arguments[2], out int displacement))
                    {
                        engines.Add(new Engine(model, power, displacement));
                    }
                    else
                    {

                        string efficiency = arguments[2];

                        engines.Add(new Engine(model, power, efficiency));
                    }
                }
                else if (arguments.Length == 4)
                {
                    int displacement = int.Parse(arguments[2]);
                    string efficiency = arguments[3];

                    engines.Add(new Engine(model, power, displacement, efficiency));
                }

            }

            //Information about a Car
            int numbersOfCars = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < numbersOfCars; i++)
            {
                string[] information = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = information[0];
                string engine = information[1];

                //Check name of engines
                Engine currentEngine = engines
                    .Where(e => e.Model == engine)
                    .FirstOrDefault();

                if (information.Length == 2)
                {
                    cars.Add(new Car(model, currentEngine));
                }
                else if (information.Length == 3)
                {
                    if (int.TryParse(information[2], out int weight))
                    {
                        cars.Add(new Car(model, currentEngine, weight));
                    }
                    else
                    {
                        string color = information[2];
                        cars.Add(new Car(model, currentEngine, color));
                    }
                }
                else if (information.Length == 4)
                {
                    int weight = int.Parse(information[2]);
                    string color = information[3];

                    cars.Add
                        (
                        new Car(model,currentEngine,weight,color)
                        );
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
