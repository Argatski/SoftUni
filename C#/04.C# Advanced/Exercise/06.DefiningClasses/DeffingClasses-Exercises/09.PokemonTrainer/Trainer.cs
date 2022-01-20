using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Trainer
    {
        //Fields
        private List<Pokemon> pokemons;

        //Properties
        public string Name { get; set; }
        public int NumberOfBadges { get; set; }

        //Constructor
        public Trainer(string name)
        {
            Name = name;
            NumberOfBadges = 0;
            pokemons = new List<Pokemon>();
        }

        //Methods
        /// <summary>
        /// Add pokemons for every trainer. 
        /// </summary>
        /// <param name="pokemon"></param>
        public void AddPokemons(Pokemon pokemon)
        {
            pokemons.Add(pokemon);
        }

        /// <summary>
        /// For every command you must check if a trainer has at least 1 pokemon with the given element. 
        /// </summary>
        /// <param name="element"></param>
        public void CheckPokemons(string element)
        {
            foreach (var pokemon in pokemons)
            {
                //If he does, he receives 1 badge. 
                if (pokemon.Element == element)
                {
                    NumberOfBadges++;
                    break;
                }
                //Otherwise, all of his pokemon lose 10 health. 
                else
                {
                    pokemon.Health -= 10;
                }
            }

            //
            for (int i = 0; i < pokemons.Count; i++)
            {
                Pokemon pokemon = pokemons[i];

                //If a pokemon falls to 0 or less health, he dies and must be deleted from the trainer’s collection. 
                if (pokemon.Health <= 0)
                {
                    pokemons.Remove(pokemon);
                    i--;
                }
            }
        }

        /// <summary>
        /// Pritn format
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Name} {NumberOfBadges} {pokemons.Count}";
        }
    }
}
