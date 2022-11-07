using GrandPrix.Models.Cars;

namespace GrandPrix.Models.Drivers
{
    public class EnduranceDriver : Driver
    {
        private const double enduranceDriverConsumption = 1.5;
        public EnduranceDriver(string name, Car car)
            : base(name, car, enduranceDriverConsumption)
        {
        }
    }
}
