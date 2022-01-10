using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    class Person
    {
        //Privete
        private string name;
        private int age;

        /*
        //Properties
        public string Name { get; set; }
        public int Age { get; set; }
        */
        //
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        // Constructors
        public Person()//defualt constructor
        {

        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        
        /*
        //Method
        public override string ToString()
        {
            return $"Name:{Name}, Age:{Age}";
        }
        */
    }
}
