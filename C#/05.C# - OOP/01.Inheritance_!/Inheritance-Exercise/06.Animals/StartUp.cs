using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            while (true)
            {
                try
                {
                    var command = Console.ReadLine();

                    if (command == "Beast!")
                    {
                        break;
                    }
                    var animalInfo = Console.ReadLine()
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    string name = animalInfo[0];
                    int age = int.Parse(animalInfo[1]);
                    string gender = animalInfo[2];

                    switch (command)
                    {
                        case "Dog":
                            var dog = new Dog(name, age, gender);
                            animals.Add(dog);
                            break;
                        case "Cat":
                            var cat = new Cat(name, age, gender);
                            animals.Add(cat);
                            break;
                        case "Frog":
                            var frog = new Frog(name, age, gender);
                            animals.Add(frog);
                            break;
                        case "Kitten":
                            var kitten = new Kitten(name, age);
                            animals.Add(kitten);
                            break;
                        case "Tomcat":
                            var tomcat = new Tomcat(name, age);
                            animals.Add(tomcat);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }

                
            }
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
        }
    }
}
