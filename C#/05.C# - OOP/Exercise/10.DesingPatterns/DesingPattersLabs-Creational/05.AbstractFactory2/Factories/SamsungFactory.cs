using _05.AbstractFactory2.Contracts;
using _05.AbstractFactory2.Samsung;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.AbstractFactory2.Factories
{
    public class SamsungFactory : ITechnologyAbstractFactory
    {
        public IMobilePhone CreatePhone()
        {
            return new SamsungPhone();
        }

        public ITablet CreateTable()
        {
            return new SamsungTablet();

        }
    }
}
