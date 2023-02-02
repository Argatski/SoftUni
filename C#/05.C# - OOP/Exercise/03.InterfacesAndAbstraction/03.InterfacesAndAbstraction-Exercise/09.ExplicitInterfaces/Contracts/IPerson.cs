using System;
using System.Collections.Generic;
using System.Text;

namespace ExplicitInterfaces.Contracts
{
    public interface IPerson
    {
        public string Name { get; }
        public int Age { get; }
        string GetName();
    }
}
