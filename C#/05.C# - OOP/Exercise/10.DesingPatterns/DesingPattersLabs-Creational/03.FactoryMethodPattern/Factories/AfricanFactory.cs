using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.FactoryMethodPattern.Contracts;

namespace _03.FactoryMethodPattern.Factories
{
    class AfricanFactory : IAnimalFactory
    {
        public ICarnivore GetCarnivore()
        {
            return new Lion();
        }


    }
}
