using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        //Fields
        private string make;
        private string model;
        private int year;

        
        //Properties
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        
        /*
        //Another 
        public string Make
        {
            get { return make; }
            set { make = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        */

    }
}

