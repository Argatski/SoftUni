using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses

{
    class StartUp
    {
        static void Main(string[] args)
        {
            /*First etap.
             * You will be receiving lines until you receive the command "Tournament". Each line will carry information about a pokemon and the trainer who caught it in the format:
                "{trainerName} {pokemonName} {pokemonElement} {pokemonHealth}"
             */

            string arguments;
            var trainers = new Dictionary<string, Trainer>();

            while ((arguments = Console.ReadLine()) != "Tournament")
            {
                string[] input = arguments
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                //Triner information
                string trainerName = input[0];

                //Pokemon information
                string pokemonName = input[1];
                string element = input[2];
                int health = int.Parse(input[3]);

                //Instance Pokemon
                Pokemon pokemon = new Pokemon(pokemonName, element, health);

                //Instance Trainer
                //Is name unique
                if (!trainers.ContainsKey(trainerName))
                {
                    trainers.Add(trainerName, new Trainer(trainerName));
                }

                trainers[trainerName].AddPokemons(pokemon);
            }

            //Second etap
            /*After receiving the command "Tournament", you will start receiving commands until the "End" command is received. They can contain one of the following:
             * •	"Fire"
               •	"Water"
               •	"Electricity"
             */

            while ((arguments = Console.ReadLine()) != "End")
            {
                switch (arguments)
                {
                    case "Fire":
                        foreach (var trainer in trainers.Values)
                        {
                            trainer.CheckPokemons(arguments);
                        }
                        break;
                    case "Water":
                        foreach (var trainer in trainers.Values)
                        {
                            trainer.CheckPokemons(arguments);
                        }
                        break;
                    case "Electricity":
                        foreach (var trainer in trainers.Values)
                        {
                            trainer.CheckPokemons(arguments);
                        }
                        break;
                }
            }

            //Print output.
            Print(trainers);
        }

        private static void Print(Dictionary<string, Trainer> trainers)
        {
            var result = trainers.Values.OrderByDescending(b => b.NumberOfBadges).ToList();

            foreach (var trainer in result)
            {
                Console.WriteLine(trainer);
            }
        }
    }
}

/*
 *   //Input
            string command;

            var trainers = new Dictionary<string,TrainerHelper>();

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
                PokemonHelper pokemon = new PokemonHelper
                    (
                    pokemonName, pokemonElemnt, pokemonHealth
                    );

                //Is name unique 
                if (!trainers.ContainsKey(trainerName))
                {
                    trainers.Add(trainerName, new TrainerHelper(trainerName));
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
 */
