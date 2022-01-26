using System;
using System.Collections.Generic;
using System.Text;

namespace _11.Google
{
    public class Person
    {
        public string name;
        public Company company;
        public Car car;
        public List<Pokemon> pokemons;
        public List<Parent> parents;
        public List<Child> children;

        //Consturctor
        public Person(string name)
        {
            this.name = name;
            this.car = null;
            this.pokemons = new List<Pokemon>();
            this.parents = new List<Parent>();
            this.children = new List<Child>();
        }
    }
}
