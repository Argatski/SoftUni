using SOLID_Exercises.Models.Contracts;
using SOLID_Exercises.Models.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Exercises.Models.Error
{
    public class Error : IError
    {
        public Error(DateTime dateTime, string message, Level level = Level.INFO)
        {
            this.DateTime = dateTime;
            this.Message = message;
            this.Level = level;
        }
        public DateTime DateTime { get; }

        public string Message { get; }

        public Level Level { get; }
    }
}
