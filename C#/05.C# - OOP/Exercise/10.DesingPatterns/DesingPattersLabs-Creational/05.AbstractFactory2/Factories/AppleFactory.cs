using _05.AbstractFactory2.Apple;
using _05.AbstractFactory2.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.AbstractFactory2.Factories
{
    internal class AppleFactory : ITechnologyAbstractFactory
    {
        public IMobilePhone CreatePhone()
        {
            return new ApplePhone();
        }

        public ITablet CreateTable()
        {
            return new AppleTablet();

        }
    }
}
