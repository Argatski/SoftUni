using GrandPrix.Exception;
using GrandPrix.Models.Cars.Contract;
using GrandPrix.Models.Tyres;
using System;

namespace GrandPrix.Models.Cars
{
    public class Car : Tyre, ICar
    {
        private double MaxTankCapacity = 160.0;

        private int hp;
        private double fuelAmount;
        private Tyre tyre;

        protected Car(string name, double hardness)
            : base(name, hardness)
        {
            this.Hp = this.hp;
            this.FuelAmount = this.fuelAmount;
        }

        public Tyre Tyre
        {
            get { return this.tyre; }
            private set { this.tyre = value; }
        }

        public int Hp
        {
            get { return this.hp; }
            protected set { this.hp = value; }
        }

        public double FuelAmount
        {
            get { return this.fuelAmount; }
            private set
            {

                if (value < 0)
                {
                    throw new ArgumentException(ErroMessage.OutOffuel);
                }
                if (value > MaxTankCapacity)
                {
                    value = MaxTankCapacity;
                }
                else
                {
                    this.fuelAmount = value;
                }
            }
        }

        public void Refule(double fuel)
        {
            this.FuelAmount += fuel;
        }
        public void ChangeTyress(Tyre newTyre)
        {
            this.Tyre = newTyre;
        }
        public void ReduceFuel(int length, double fuelConsumptionPerKm)
        {
            this.FuelAmount -= length * fuelConsumptionPerKm;
        }
    }
}
