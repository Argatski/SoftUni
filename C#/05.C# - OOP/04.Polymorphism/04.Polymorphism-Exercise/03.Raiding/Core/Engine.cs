using Raiding.Contracts;
using Raiding.Factories;
using Raiding.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Raiding.Core
{
    public class Engine : IEngine
    {
        private ICollection<BaseHero> collection;
        public Engine()
        {
            collection = new List<BaseHero>();
        }

        public void Run()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string name = Console.ReadLine();
                string type = Console.ReadLine();

                try
                {
                    BaseHero baseHero = FactoriesHeroes.CeateHero(type, name);
                    collection.Add(baseHero);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            double bossPower = double.Parse(Console.ReadLine());

            foreach (var hero in collection)
            {
                Console.WriteLine(hero.CastAbility());
            }

            int sum = collection.Sum(x => x.Power);

            if (sum >= bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }


    }
}
