using GrandPrix.Models.Cars;
using GrandPrix.Models.Drivers.Contracts;

namespace GrandPrix.Models.Drivers
{
    public abstract class Driver : IDriver
    {
        private string name;
        private double totalTime;
        private Car car;
        private double consumptionPerKm;

        protected Driver(string name, Car car, double fuelConsumptionPerKm)
        {
            this.Name = name;
            this.Car = car;
            this.FuelConsumptionPerKm = fuelConsumptionPerKm;
        }

        public Car Car
        {
            get { return this.car; }
            private set { this.car = value; }
        }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public double TotalTime
        {
            get { return this.totalTime; }
            private set { this.totalTime = value; }
        }

        public virtual double Speed => (this.car.Hp + this.car.Tyre.Degradation) / this.car.FuelAmount;

        public double FuelConsumptionPerKm
        {
            get { return this.consumptionPerKm; }
            private set { this.consumptionPerKm = value; }
        }
        public void ReduceFuelAmount(int lenght)
        {
            this.Car.ReduceFuel(lenght, this.FuelConsumptionPerKm);
        }
    }
}
