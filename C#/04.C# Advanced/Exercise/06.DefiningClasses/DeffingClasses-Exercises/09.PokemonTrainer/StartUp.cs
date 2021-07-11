using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses

{
    class StartUp
    {
        static void Main(string[] args)
        {
            //Input
            string command;

            var trainers = new Dictionary<string,Trainer>();

            while ((command = Console.ReadLine()) != "Tournament")
            {
                string[] arguments = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                //Trainer information
                string trainerName = arguments[0];

                //Pokemon information
                string pokemonName = arguments[1];
                string pokemonElemnt = arguments[2];
                int pokemonHealth = int.Parse(arguments[3]);

                //Initialising pokemon
                Pokemon pokemon = new Pokemon
                    (
                    pokemonName, pokemonElemnt, pokemonHealth
                    );

                //Is name unique 
                if (!trainers.ContainsKey(trainerName))
                {
                    trainers.Add(trainerName, new Trainer(trainerName));
                }

                //Add another pockemon
                trainers[trainerName].AddPokemons(pokemon);
            }

            while ((command = Console.ReadLine()) != "End")
            {
                switch (command)
                {
                    case "Fire":
                        foreach (var trainer in trainers.Values)
                        {
                            trainer.CheckPokemons(command);
                        }
                        break;
                    case "Water":
                        foreach (var trainer in trainers.Values)
                        {
                            trainer.CheckPokemons(command);
                        }
                        break;
                    case "Electricity":
                        foreach (var trainer in trainers.Values)
                        {
                            trainer.CheckPokemons(command);
                        }
                        break;
                    default:
                        break;
                }
            }

            var result = trainers.Values.OrderByDescending(x => x.NumberOfBadges).ToList();

            foreach (var trainer in result)
            {
                Console.WriteLine(trainer);
            }

        }

    }
}
