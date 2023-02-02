using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FoodShortage
{
    public class Engine
    {
        public readonly List<IBuyer> buyers;
        public Engine()
        {
            this.buyers = new List<IBuyer>();
        }
        public void Run()
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine()
                    .Split();
                AddPerson(input, buyers);
            }

            string argument;
            while ((argument = Console.ReadLine()) != "End")
            {
                var person = buyers.FirstOrDefault(b => b.Name == argument);
                if (person != null)
                {
                    person.BuyFood();
                }

            }

            int totalFoodAmount = this.buyers.Sum(x => x.Food);

            Console.WriteLine(totalFoodAmount);
        }

        private void AddPerson(string[] input, List<IBuyer> buyers)
        {
            if (input.Length == 4)
            {
                string name, id, birthdate;
                int age;

                name = input[0];
                age = int.Parse(input[1]);
                id = input[2];
                birthdate = input[3];


                IBuyer buyer = new Citizen(name, age, id, birthdate);

                buyers.Add(buyer);
            }
            else
            {
                string name, group;
                int age;

                name = input[0];
                age = int.Parse(input[1]);
                group = input[2];


                IBuyer buyer = new Rebel(name, age, group);

                buyers.Add(buyer);
            }
        }
    }
}
