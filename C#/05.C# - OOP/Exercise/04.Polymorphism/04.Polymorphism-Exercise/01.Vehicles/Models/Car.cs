using Vehicles.Contracts;

namespace Vehicles.Models
{
    public class Car : Vehicle
    {
        private const double airConditionerConsumption = 0.9;

        public Car(double fuelQuantity, double litersPerKm)
            : base(fuelQuantity, litersPerKm + airConditionerConsumption)
        {
        }
    }
}
