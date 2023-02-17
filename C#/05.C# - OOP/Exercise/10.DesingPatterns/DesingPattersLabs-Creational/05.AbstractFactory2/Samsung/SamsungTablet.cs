using _05.AbstractFactory2.Contracts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.AbstractFactory2.Samsung
{
    internal class SamsungTablet : ITablet
    {
        public string OS { get; set; }
    }
}
