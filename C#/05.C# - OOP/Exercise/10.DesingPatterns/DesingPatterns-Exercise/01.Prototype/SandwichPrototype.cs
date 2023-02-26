using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Prototype
{
    public abstract class SandwichPrototype<T>
    {
        public abstract T ShalloClone();
        public abstract T DeepClone();
    }
}
