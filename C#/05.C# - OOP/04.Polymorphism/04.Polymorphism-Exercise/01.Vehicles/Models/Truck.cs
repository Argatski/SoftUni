using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Models
{
    public class Truck : Vehicle
    {
        private const double airConditionerConsumption = 1.6;
        private const double fuelWastage = 0.95;
        public Truck(double fuelQuantity, double litersPerKm)
            : base(fuelQuantity, litersPerKm + airConditionerConsumption)
        {
        }

        public override void AmountOfFuel(double fuel)
        {
            this.FuelQuantity += fuel * fuelWastage;
        }
    }
}
