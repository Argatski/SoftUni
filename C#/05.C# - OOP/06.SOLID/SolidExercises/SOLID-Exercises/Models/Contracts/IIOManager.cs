using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Exercises.Models.Contracts
{
    public interface IIOManager
    {
        string CurrentDirectoryPath { get; }
        string CurrentFilePath { get; }

        void EnsureDirectoryAndFileExist();
        string GetCurrentPath();
    }
}
