using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.FacadePattern
{
    internal interface IDrawable
    {
        public string Name { get; set; }
        public void Draw(int level);
        public void AddChild(IDrawable child);
    }
}
