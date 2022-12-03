using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Exercises.Models.Contracts
{
    public interface IFile
    {
        string Path { get; }
        ulong Size { get; }
        string Write(ILayout layout, IError error);
    }
}
