using _05.AbstractFactory2.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.AbstractFactory2.Apple
{
    public class AppleTablet : ITablet
    {
        public string OS { get; set; }
    }
}
