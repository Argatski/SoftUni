using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.TemplatePattern
{
    public class WholeGrainBread : Bread
    {
        public override void Bake()
        {
            Console.WriteLine("10 min.");
        }

        public override void MixIngridients()
        {
            Console.WriteLine("a lot of seeds");
        }

        public override void Slice()
        {
            Console.WriteLine("Sliced 2");
        }
    }
}
