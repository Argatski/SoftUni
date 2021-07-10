using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Cargo
    {
        //Properties
        public int Weight { get; set; }
        public string Type { get; set; }

        //Constructors
        public Cargo(int weight,string type)
        {
            Weight = weight;
            Type = type;
        }
    }
}
