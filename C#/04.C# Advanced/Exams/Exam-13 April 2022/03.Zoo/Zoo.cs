using System.Collections.Generic;
using System.Linq;

namespace Zoo
{
    public class Zoo
    {
        public List<Animal> Animals = new List<Animal>();
        public string Name { get; set; }
        public int Capacity { get; set; }

        public Zoo(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
        }

        /// <summary>
        /// Adds an Animal to the animals' collection.
        /// </summary>
        /// <param name="animal"></param>
        /// <returns></returns>
        public string AddAnimal(Animal animal)
        {
            string result = string.Empty;

            if (animal.Species == null || animal.Species == " ")
            {
                result = "Invalid animal species.";
            }
            else if (animal.Diet != "herbivore" && animal.Diet != "carnivore")
            {
                result = "Invalid animal diet.";
            }
            else if (Animals.Count == Capacity)
            {
                result = "The zoo is full.";
            }
            else
            {
                result = $"Successfully added {animal.Species} to the zoo.";
                Animals.Add(animal);
            }

            return result;
        }

        /// <summary>
        /// Removes all animals by given species, as a result, return the count of the animals which were removed.
        /// </summary>
        /// <param name="species"></param>
        /// <returns></returns>
        public int RemoveAnimals(string species)
        {
            int count = Animals.Count;

            Animals.RemoveAll(a => a.Species == species);

            return count -= Animals.Count;
        }

        /// <summary>
        /// Search and returns a list of animals by given diet.
        /// </summary>
        /// <param name="diet"></param>
        /// <returns></returns>
        public List<Animal> GetAnimalsByDiet(string diet)
        {
            List<Animal> animalsDiet = new List<Animal>();

            animalsDiet = Animals.Where(a => a.Diet == diet).ToList();

            return animalsDiet;
        }

        public Animal GetAnimalByWeight(double weight)
        {
            Animal animalWeight = new Animal();

            animalWeight = Animals.FirstOrDefault(a => a.Weight == weight);

            return animalWeight;
        }

        public string GetAnimalCountByLength(double minimumLength, double maximumLength)
        {
            int count = 0;

            foreach (var animal in Animals)
            {
                if (animal.Lenght >= minimumLength && animal.Lenght <= maximumLength)
                {
                    count++;
                }
            }

            string result = $"There are {count} animals with a length between {minimumLength} and {maximumLength} meters.";

            return result;
        }
    }
}
