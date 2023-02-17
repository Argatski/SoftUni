using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.AbstractFactory2.Contracts
{
    public interface ITechnologyAbstractFactory
    {
        IMobilePhone CreatePhone();
        ITablet CreateTable();
    }
}
