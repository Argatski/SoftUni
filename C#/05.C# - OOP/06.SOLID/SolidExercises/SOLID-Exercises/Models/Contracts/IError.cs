using SOLID_Exercises.Models.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Exercises.Models.Contracts
{
    public interface IError
    {
        DateTime DateTime { get; }
        string Message { get; }
        Level Level { get; }
    }
}
