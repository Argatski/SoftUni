using GrandPrix.Models.Cars;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrandPrix.Models.Drivers
{
    public class AggressiveDriver : Driver
    {
        private const double aggressiveFuelConsumpton = 2.7;
        private const double multipliedSpeed = 1.3;
        public AggressiveDriver(string name, Car car)
            : base(name, car, aggressiveFuelConsumpton)
        {
        }
        public override double Speed => base.Speed * multipliedSpeed;
    }
}
