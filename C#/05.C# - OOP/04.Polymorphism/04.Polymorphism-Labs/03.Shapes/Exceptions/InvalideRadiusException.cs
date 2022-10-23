using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class InvalideRadiusException : Exception
    {
        private const string ExceptionMessage = "Radius must be a positive number!";

        public InvalideRadiusException()
            : base(ExceptionMessage)
        {
        }
    }
}
