using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Exercises.Exceptions
{
    public class InvalidLayoutTypeException : Exception
    {
        private const string ExceptionMessage = "Invalid Layout Type!";

        public InvalidLayoutTypeException() : base(ExceptionMessage)
        {
        }
        public InvalidLayoutTypeException(string message) : base(message)
        {

        }
    }
}
