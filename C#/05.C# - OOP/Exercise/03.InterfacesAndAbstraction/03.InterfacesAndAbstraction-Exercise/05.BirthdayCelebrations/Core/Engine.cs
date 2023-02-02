using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BirthdayCelebrations
{
    public class Engine
    {
        private readonly List<IMammal> mammals;
        private readonly List<IIdentifiable> identifiables;
        public Engine()
        {
            mammals = new List<IMammal>();
            identifiables = new List<IIdentifiable>();
        }

        public void Run()
        {
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] input = command.Split();

                string type = input[0];
                switch (type)
                {
                    case "Robot":
                        AddRobot(input, identifiables);
                        break;
                    case "Citizen":
                        AddCitizen(input, mammals);
                        break;
                    case "Pet":
                        AddPet(input, mammals);
                        break;
                }
            }
            string year = Console.ReadLine();

            foreach (var mammal in this.mammals.Where(m => m.Birthdate.EndsWith(year)))
            {
                Console.WriteLine(mammal);
            }
        }

        private void AddPet(string[] input, List<IMammal> mammals)
        {
            string name, birthdate;

            name = input[1];
            birthdate = input[2];

            IMammal pet = new Pet(name, birthdate);
            mammals.Add(pet);
        }

        private void AddCitizen(string[] input, List<IMammal> mammals)
        {
            string name, id, birthdate;
            int age;

            name = input[1];
            age = int.Parse(input[2]);
            id = input[3];
            birthdate = input[4];

            IMammal citizen = new Citizen(name, age, id, birthdate);
            mammals.Add(citizen);
        }

        private void AddRobot(string[] input, List<IIdentifiable> identifiables)
        {
            string model, id;

            model = input[1];
            id = input[2];

            IIdentifiable robot = new Robot(model, id);

            identifiables.Add(robot);
        }
    }
}
