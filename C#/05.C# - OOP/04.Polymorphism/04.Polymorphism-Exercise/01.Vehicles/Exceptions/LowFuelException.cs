using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Exceptions
{
    public class LowFuelException : Exception
    {
        public LowFuelException(string message)
            : base(message)
        {
        }
    }
}
