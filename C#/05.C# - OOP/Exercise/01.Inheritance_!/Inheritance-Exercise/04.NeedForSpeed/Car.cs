using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Car : Vehicle
    {
        private const double DefaultFuelConsumption = 3;
        //Constructor
        public Car(int horsePower, double fuel)
            : base(horsePower, fuel)
        {

        }

        //Method
        /*Another way to override
        public override double FuelConsumption => DefaultFuelConsumption;
        */
        public override void Drive(double kilometers)
        {
            base.Fuel -= kilometers * DefaultFuelConsumption;
        }
        
    }
}
