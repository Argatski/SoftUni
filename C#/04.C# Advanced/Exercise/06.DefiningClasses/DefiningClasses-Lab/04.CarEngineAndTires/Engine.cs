﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Engine
    {
        //Fields
        private int horsePower;
        private double cubicCapacity;

        //Properties
        public int HorsePower { get; set; }
        public double CubicCapacity { get; set; }

        //Constructor
        public Engine(int horsePower, double cubicCapacity)
        {
            HorsePower = horsePower;
            CubicCapacity = cubicCapacity;
        }
    }
}
