﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _11.Google
{
    public class Parent
    {
        //Field
        public string name;
        public string birthday;

        //Constructor
        public Parent(string name, string birthday)
        {
            this.name = name;
            this.birthday = birthday;
        }

        //Print format
        public override string ToString()
        {
            return this.name + " " + this.birthday;
        }
    }
}
