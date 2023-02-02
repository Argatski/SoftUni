using System;
using WildFarm.Common;
using WildFarm.Core;

namespace WildFarm.Factories
{
    public class AnimalFactory
    {
        public Animal Create(string type, string name, double weight, string[] args)
        {
            Animal animal = null;

            switch (args.Length)
            {
                case 1:
                    bool isBird = double.TryParse(args[0], out double wingSize);
                    if (isBird)
                    {
                        if (type == "Hen")
                        {
                            animal = new Hen(name, weight, wingSize);
                        }
                        else if (type == "Owl")
                        {
                            animal = new Owl(name, weight, wingSize);
                        }
                        else
                        {
                            throw new InvalidOperationException(ExceptionMessages.InvalidType);
                        }
                    }
                    else
                    {
                        string livingRegion = args[0];

                        if (type == "Mouse")
                        {
                            animal = new Mouse(name, weight, livingRegion);
                        }
                        else if (type == "Dog")
                        {
                            animal = new Dog(name, weight, livingRegion);

                        }
                        else
                        {
                            throw new InvalidOperationException(ExceptionMessages.InvalidType);
                        }
                    }
                    break;
                case 2:
                    string livingR = args[0];
                    string breed = args[1];
                    if (type == "Cat")
                    {
                        animal = new Cat(name, weight, livingR, breed);
                    }
                    else if (type == "Tiger")
                    {
                        animal = new Tiger(name, weight, livingR, breed);
                    }
                    else
                    {
                        throw new InvalidOperationException(ExceptionMessages.InvalidType);
                    }
                    break;

            }
            return animal;
        }
    }
}
