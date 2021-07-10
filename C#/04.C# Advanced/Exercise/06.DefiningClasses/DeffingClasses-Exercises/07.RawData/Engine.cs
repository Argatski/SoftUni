using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Engine
    {
        //Properties
        public int Speed { get; set; }
        public int Power { get; set; }

        //Constructor
        public Engine(int speed,int power)
        {
            Speed = speed;
            Power = power;
        }
        
    }
}
