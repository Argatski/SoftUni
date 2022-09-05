using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class RaceMotorcycle : Motorcycle
    {
        //Field
        private const double DefaultFuelConsumption = 8;

        //Constructor
        public RaceMotorcycle(int horsePower, double fuel)
            : base(horsePower, fuel)
        {

        }

        /*Another way to override
        public override double FuelConsumption => DefaultFuelConsumption;
        */

        //Use virtual method Vehicle=>Motorcycle=>RaseMotorCycle
        public override void Drive(double kilometers)
        {
            base.Fuel -= kilometers * DefaultFuelConsumption;
        }

    }
}
