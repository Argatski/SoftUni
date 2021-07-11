using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses

{
    public class Trainer
    {
        //Fields
        private List<Pokemon> pokemos;

        //Properties
        public string Name { get; set; }

        public int NumberOfBadges { get; set; } 


        //Constructor
        public Trainer(string name)
        {
            Name = name;
            NumberOfBadges = 0;
            pokemos = new List<Pokemon>();
        }

        //Mehtonds
        public void AddPokemons(Pokemon pokemon)
        {
            pokemos.Add(pokemon);
        }

        public void CheckPokemons(string element) 
        {
            foreach (var pokemon in pokemos)
            {
                if (pokemon.Element==element)
                {
                    NumberOfBadges++;
                    break;
                }
                else
                {
                    pokemon.Health -= 10;
                }
            }

            for (int i = 0; i < pokemos.Count; i++)
            {
                Pokemon pokemon = pokemos[i];

                if (pokemon.Health<=0)
                {
                    pokemos.Remove(pokemon);
                    i--;
                }
            }
        }

        public override string ToString()
        {
            return $"{Name} {NumberOfBadges} {pokemos.Count}"; 
        }
    }
}
