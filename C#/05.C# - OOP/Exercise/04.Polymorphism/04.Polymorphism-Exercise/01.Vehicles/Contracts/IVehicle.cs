using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Contracts
{
    public interface IVehicle
    {
        public double FuelQuantity { get; }
        public double LitersPerKm { get; }

        public abstract string Drive(double distance);
        public abstract void AmountOfFuel(double fuel);
    }
}
