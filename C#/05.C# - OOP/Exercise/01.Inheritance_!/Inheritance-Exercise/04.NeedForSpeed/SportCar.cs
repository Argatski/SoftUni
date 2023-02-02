using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class SportCar : Car
    {
        private const double DefaultFuelConsumption = 10;

        public SportCar(int horsePower, double fuel)
            : base(horsePower, fuel)
        {
        }
        /*Another way to override
        public override double FuelConsumption => DefaultFuelConsumption;
        */
        public override void Drive(double kilometers)
        {
            base.Fuel -= kilometers * DefaultFuelConsumption;
        }
    }
}
