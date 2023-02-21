using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.FacadePattern
{
    internal class SimpleShape : IDrawable
    {
        public string Name { get; set; }
        public SimpleShape(string name)
        {
            this.Name = name;
        }

        public void AddChild(IDrawable child)
        {
            throw new ArgumentException("Simple Shapes connot have children");
        }

        public void Draw(int level)
        {
            Console.Write(new string(' ', level));
            Console.WriteLine(this.Name);
        }
    }
}
