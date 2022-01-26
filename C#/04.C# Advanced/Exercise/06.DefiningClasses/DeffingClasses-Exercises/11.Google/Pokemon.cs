using System;
using System.Collections.Generic;
using System.Text;

namespace _11.Google
{
    public class Pokemon
    {
        //Field
        public string name;
        public string type;

        //Constructor
        public Pokemon(string name, string type)
        {
            this.name = name;
            this.type = type;
        }

        //Print format
        public override string ToString()
        {
            return this.name + " " + this.type;
        }
    }
}
