using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Engine
    {
        //Properties
        public int HorsePower { get; set; }
        public double CubicCapasity { get; set; }

        //Constructor
        public Engine(int horsePower, double cubicCapasity)
        {
            HorsePower = horsePower;
            CubicCapasity = cubicCapasity;
        }
    }
}
