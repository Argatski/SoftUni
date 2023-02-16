using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SimpleFactoryPattern
{
    public class AnimalFactory
    {
        public static IAnimal CreateAnima(string animal)
        {
            if (animal == "Lion")
            {
                return new Lion();
            }
            else if (animal == "Cat")
            {
                return new Cat();
            }
            return null;
        }
    }
}
