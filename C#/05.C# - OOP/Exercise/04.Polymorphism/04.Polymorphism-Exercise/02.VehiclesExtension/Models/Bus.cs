namespace VehiclesExtension.Models
{
    using VehiclesExtension.Contract;
    using VehiclesExtension.Exceptions;

    public class Bus : Vehicle, IBus
    {
        private const double AirConditionConsumption = 1.4;

        public Bus(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity)
            : base(fuelQuantity, fuelConsumptionPerKm + AirConditionConsumption, tankCapacity)
        {
        }

        public string DriveEmpty(double distance)
        {
            this.FuelConsumptionPerKm -= AirConditionConsumption;
            return base.Drive(distance);
        }
    }
}
