using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Tire
    {
        //Properties
        public int Year { get; set; }
        public double Pressure { get; set; }

        //Constructor
        public Tire(int year, double pressure)
        {
            Year = year;
            Pressure = pressure;
        }
    }
}
