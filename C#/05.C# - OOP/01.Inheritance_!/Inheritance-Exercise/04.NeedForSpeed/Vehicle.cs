using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        private const double DefualtConsmuption = 1.25;
        ///Constructor
        public Vehicle(int horsePower, double fuel)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
        }

        //Properties
        public int HorsePower { get; set; }
        public double Fuel { get; set; }
        public virtual double FuelConsumption => DefualtConsmuption;

        //Mehtods
        /// <summary>
        /// The Drive method should have a functionality to reduce the Fuel based on the traveled kilometers.
        /// </summary>
        /// <param name="kilometers"></param>
        public virtual void Drive(double kilometers)
        {
            this.Fuel -= kilometers * this.FuelConsumption;//The default fuel consumption for Vehicle is 1.25. 
        }

        
        public override string ToString()
        {
            return $"Type: {GetType().Name}  FuelConsumption: {this.FuelConsumption} Fuel: {this.Fuel} Horse: {this.HorsePower}";
        }
        
    }
}
