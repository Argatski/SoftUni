using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
        //Properties
        public string Name { get; set; }
        public int Age { get; set; }

        //Constructors
        /// <summary>
        ///DefautThe first should take no arguments and produce a person with name "No name" and age = 1. 
        /// </summary>
        public Person()
        {
            Name = "No name";
            Age = 1;
        }
        /// <summary>
        /// The second should accept only an integer number for the age and produce a person with name "No name" and age equal to the passed parameter.
        /// </summary>
        /// <param name="age"></param>
        public Person(int age)
            : this()
        {
            Age = age;
        }
        /// <summary>
        ///The third one should accept a string for the name and an integer for the age and should produce a person with the given name and age.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        public Person(string name, int age)
            : this(age)
        {
            Name = name;
            Age = age;
        }

        //Method
        public override string ToString()
        {
            return $"{Name} {Age}";
        }
    }
}
