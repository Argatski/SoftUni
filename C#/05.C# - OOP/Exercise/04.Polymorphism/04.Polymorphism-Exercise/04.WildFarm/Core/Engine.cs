using System;
using System.Collections.Generic;
using System.Linq;
using WildFarm.Factories;

namespace WildFarm.Core
{
    public class Engine : IEngine
    {
        private readonly ICollection<Animal> animals;

        private readonly AnimalFactory animalFactory;
        private readonly FoodFactory foodFactory;
        public Engine()
        {
            this.animals = new HashSet<Animal>();

            this.animalFactory = new AnimalFactory();
            this.foodFactory = new FoodFactory();
        }
        public void Run()
        {

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] animalArgs = command.Split();

                string type = animalArgs[0];
                string name = animalArgs[1];
                double weight = double.Parse(animalArgs[2]);
                string[] args = animalArgs
                    .Skip(3).ToArray();

                Animal animal = null;
                try
                {
                    animal = this.animalFactory.Create(type, name, weight, args);
                    this.animals.Add(animal);
                    Console.WriteLine(animal.Sound());
                }
                catch (InvalidOperationException ion)
                {
                    Console.WriteLine(ion.Message);
                }

                string[] foodArgs = Console.ReadLine()
                    .Split();
                string typeFood = foodArgs[0];
                int quantity = int.Parse(foodArgs[1]);

                try
                {
                    Food food = this.foodFactory.Create(typeFood, quantity);

                    animal?.Feed(food);
                }
                catch (InvalidOperationException ion)
                {
                    Console.WriteLine(ion.Message);
                }
            }

            foreach (var animal in this.animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
