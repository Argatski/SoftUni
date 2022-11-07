using GrandPrix.Models.Tyres;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrandPrix.Models.Cars.Contract
{
    public interface ICar
    {
        int Hp { get; }
        double FuelAmount { get; }
    }
}
