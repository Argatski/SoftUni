using SOLID_Exercises.Factories.Contracts;
using SOLID_Exercises.Models.Contracts;
using SOLID_Exercises.Models.Files;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Exercises.Factories
{
    public class LogFileFactory : ILogFileFactory
    {
        public IFile GetLogFile() => new LogFile();
    }
}
