using SOLID_Exercises.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Exercises.Factories.Contracts
{
    public interface ILogFileFactory
    {
        IFile GetLogFile();
    }
}
