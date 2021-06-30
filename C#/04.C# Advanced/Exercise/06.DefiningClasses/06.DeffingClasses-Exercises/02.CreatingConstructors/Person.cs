﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
        //Properties
        public string Name { get; set; }
        public int Age { get; set; }

        //Construcotrs
        public Person()
        {
            Name = "No name";
            Age = 1;
        }

        public Person(int age)
        {
            Name = "No name";
            Age = age;
        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;

        }
    }
}
