using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    class Tesla : ICar, IElectricCar
    {
        public Tesla(string model, string color, int battery)
        {
            this.Model = model;
            this.Color = color;
            this.Battery = battery;
        }

        public string Model { get; set; }
        public string Color { get; set; }
        public int Battery { get; set; }


        public void Start()
        {
            Console.WriteLine("Engine start");
        }

        public void Stop()
        {
            Console.WriteLine("Engine Breaaak!");
        }

        public override string ToString()
        {
            return $"{this.Color} Tesla {this.Model} with {this.Battery} Batteries";
        }
    }
}
