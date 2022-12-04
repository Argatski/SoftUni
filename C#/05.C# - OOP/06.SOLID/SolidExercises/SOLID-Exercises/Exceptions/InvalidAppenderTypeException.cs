using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Exercises.Exceptions
{
    public class InvalidAppenderTypeException : Exception
    {
        private const string ExceptionMessage = "Invalid Appender Type!";

        public InvalidAppenderTypeException()
            : base(ExceptionMessage)
        {
        }
        public InvalidAppenderTypeException(string message) : base(message)
        {

        }
    }
}
