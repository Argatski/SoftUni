using System;
using Vehicles.Contracts;
using Vehicles.Exceptions;

namespace Vehicles.Models
{
    public abstract class Vehicle : IVehicle
    {
        public Vehicle(double fuelQuantity, double litersPerKm)
        {
            this.FuelQuantity = fuelQuantity;
            this.LitersPerKm = litersPerKm;
        }
        public double FuelQuantity { get; protected set; }

        public double LitersPerKm { get; protected set; }

        public virtual void AmountOfFuel(double fuel)
        {
            this.FuelQuantity += fuel;
        }
        public string Drive(double distance)
        {
            bool carDrive = this.FuelQuantity >= this.LitersPerKm * distance;

            if (!carDrive)
            {
                throw new LowFuelException($"{this.GetType().Name} needs refueling");
            }
            this.FuelQuantity -= this.LitersPerKm * distance;
            return $"{this.GetType().Name} travelled {distance} km";
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }

    }
}
 