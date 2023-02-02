using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtension.Exceptions
{
    public class LowFuelException : Exception
    {
        public LowFuelException(string message)
            : base(message)
        {
        }
    }
}
