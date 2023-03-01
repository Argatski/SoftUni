using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.TemplatePattern
{
    public abstract class Bread
    {
        public abstract void Bake();
        public abstract void MixIngridients();
        public abstract void Slice();
        public void Make()
        {
            this.MixIngridients();
            this.Bake();
            this.Slice();
        }

    }
}
