using System;

namespace VehiclesExtension.Exceptions
{
    public class FuelOutOfTankException : Exception
    {
        public FuelOutOfTankException(string message) 
            : base(message)
        {
        }
    }
}
