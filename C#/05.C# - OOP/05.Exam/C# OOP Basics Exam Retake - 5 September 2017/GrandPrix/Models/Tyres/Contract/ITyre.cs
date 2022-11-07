using System;
using System.Collections.Generic;
using System.Text;

namespace GrandPrix.Models.Tyres.Contract
{
    public interface ITyre
    {
        string Name { get; }
        double Hardness { get; }
        double Degradation { get; }
    }
}
