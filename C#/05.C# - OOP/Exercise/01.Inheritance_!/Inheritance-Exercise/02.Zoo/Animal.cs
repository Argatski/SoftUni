﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Animal
    {

        //Constructor
        public Animal(string name)
        {
            this.Name = name;
        }
        public string Name { get; private set; }

    }
}
