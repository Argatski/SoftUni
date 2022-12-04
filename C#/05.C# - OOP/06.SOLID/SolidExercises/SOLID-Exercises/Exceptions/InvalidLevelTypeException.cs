using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Exercises.Exceptions
{
    public class InvalidLevelTypeException : Exception
    {
        private const string ExceptionMessage = "Invalid Level Type!";

        public InvalidLevelTypeException() : base(ExceptionMessage)
        {
        }
        public InvalidLevelTypeException(string message) : base(message)
        {
        }
    }
}
