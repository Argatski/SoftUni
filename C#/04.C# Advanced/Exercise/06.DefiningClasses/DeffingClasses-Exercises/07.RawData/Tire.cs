using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Tire
    {
        //Properties
        public double Pressure { get; set; }
        public int Age { get; set; }

        //Constructors
        public Tire(double pressure, int age)
        {
            Pressure = pressure;
            Age = age;

        }
    }
}
