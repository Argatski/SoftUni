using System;
using System.Collections.Generic;
using System.Text;

namespace GrandPrix.Models.Drivers.Contracts
{
    public interface IDriver
    {
        string Name { get; }
        double TotalTime { get; }
        double FuelConsumptionPerKm { get; }
        double Speed { get; }
    }
}
