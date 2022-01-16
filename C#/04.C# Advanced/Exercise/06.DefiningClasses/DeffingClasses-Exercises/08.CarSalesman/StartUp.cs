using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //Numbers about engines
            int numberOfEngines = int.Parse(Console.ReadLine());

            //List of engines
            List<Engine> engines = new List<Engine>();

            //Create engines
            CreateEnginesList(numberOfEngines, engines);


            //Numbers about a Car
            int numbersOfCars = int.Parse(Console.ReadLine());

            //List of cars
            List<Car> cars = new List<Car>();

            //Create of cars
            CreateCarsList(numbersOfCars, cars, engines);

            //Print output
            PrintResult(cars);
        }
        /// <summary>
        /// Your task is to print all the cars in the order they were received and their information in the format defined bellow. If any of the optional fields is missing, print "n/a".
        /// </summary>
        /// <param name="cars"></param>
        private static void PrintResult(List<Car> cars)
        {
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }

        /// <summary>
        /// Method about creating cars list.
        /// </summary>
        /// <param name="numbersOfCars"></param>
        /// <param name="cars"></param>
        private static void CreateCarsList(int numbersOfCars, List<Car> cars, List<Engine> engines)
        {
            for (int i = 0; i < numbersOfCars; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = input[0];
                string engine = input[1];

                Engine currentEngine = engines
                    .Where(e => e.Model == engine)
                    .FirstOrDefault();

                if (input.Length == 2)
                {
                    cars.Add(new Car(model, currentEngine));
                }
                else if (input.Length == 3)
                {
                    if (int.TryParse(input[2], out int weight))
                    {
                        cars.Add(new Car(model, currentEngine, weight));
                    }
                    else
                    {
                        string color = input[2];
                        cars.Add(new Car(model, currentEngine, color));
                    }
                }
                else if (input.Length == 4)
                {
                    int weight = int.Parse(input[2]);
                    string color = input[3];

                    cars.Add(new Car(model, currentEngine, weight, color));
                }
            }
        }

        /// <summary>
        /// Method about creating engines list.
        /// </summary>
        /// <param name="numberOfEngines"></param>
        /// <param name="engines"></param>
        private static void CreateEnginesList(int numberOfEngines, List<Engine> engines)
        {
            for (int i = 0; i < numberOfEngines; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = input[0];
                int power = int.Parse(input[1]);

                //Instance
                if (input.Length == 2)
                {
                    Engine engine = new Engine(model, power);
                    engines.Add(engine);
                }
                else if (input.Length == 3)
                {
                    if (int.TryParse(input[2], out int displacement))
                    {
                        Engine engine = new Engine(model, power, displacement);
                        engines.Add(engine);
                    }
                    else
                    {
                        string efficiency = input[2];
                        Engine engine = new Engine(model, power, efficiency);
                        engines.Add(engine);
                    }
                }
                else if (input.Length == 4)
                {
                    int displacement = int.Parse(input[2]);
                    string efficiency = input[3];

                    Engine engine = new Engine(model, power, displacement, efficiency);
                    engines.Add(engine);
                }

            }
        }
    }
}

/*
 *  //Input engines
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
            
 */
