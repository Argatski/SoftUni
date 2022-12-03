using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Exercises.Models.Contracts
{
    public interface ILogger
    {
        IReadOnlyCollection<IAppender> Appenders { get; }
        void Log(IError error);
    }
}
