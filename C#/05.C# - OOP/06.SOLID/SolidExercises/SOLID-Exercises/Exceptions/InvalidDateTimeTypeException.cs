using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Exercises.Exceptions
{
    public class InvalidDateTimeTypeException : Exception
    {
        private const string ExceptionMessage = "Invalid Date Type!";
        public InvalidDateTimeTypeException() : base(ExceptionMessage)
        {
        }
        public InvalidDateTimeTypeException(string message) : base(message)
        {
        }
        public InvalidDateTimeTypeException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
