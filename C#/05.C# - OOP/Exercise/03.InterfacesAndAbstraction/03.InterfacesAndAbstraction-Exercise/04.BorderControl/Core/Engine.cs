using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BorderControl
{
    public class Engine
    {
        private readonly List<IIdentifiable> identifiables;
        public Engine()
        {
            this.identifiables = new List<IIdentifiable>();
        }

        public void Run()
        {
            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] input = command
                    .Split();
                if (input.Length == 3)
                {
                    AddCitizen(input);
                }
                else if (input.Length == 2)
                {
                    AddRobot(input);
                }
            }

            string fakeId = Console.ReadLine();

            RemoveFake(identifiables, fakeId);
        }

        private void RemoveFake(List<IIdentifiable> identifiables, string fakeId)
        {
            foreach (var item in identifiables.Where(f => f.Id.EndsWith(fakeId)))
            {
                Console.WriteLine(item);
            }
        }

        private void AddRobot(string[] input)
        {
            string model = input[0];
            string id = input[1];

            IIdentifiable robot = new Robot(model, id);

            identifiables.Add(robot);
        }

        private void AddCitizen(string[] input)
        {
            string name = input[0];
            int age = int.Parse(input[1]);
            string id = input[2];

            IIdentifiable citizen = new Citizen(name, age, id);

            this.identifiables.Add(citizen);
        }
    }
}
