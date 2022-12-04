using SOLID_Exercises.Exceptions;
using SOLID_Exercises.Factories.Contracts;
using SOLID_Exercises.Models.Contracts;
using SOLID_Exercises.Models.Enumerations;
using SOLID_Exercises.Models.Error;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace SOLID_Exercises.Factories
{
    public class ErrorFactory : IErrorFactory
    {
        public const string DateFormat = "M/dd/yyyy h:mm:ss tt";

        public IError GetError(string dateString, string levelString, string message)
        {
            var isParsed = Enum.TryParse(levelString, out Level level);

            if (!isParsed)
            {
                throw new InvalidLevelTypeException();
            }
            DateTime dateTime;

            try
            {
                dateTime = DateTime.ParseExact(dateString, DateFormat, CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {

                throw new InvalidDateTimeTypeException();
            }
            return new Error(dateTime, message, level);
        }
    }
}
