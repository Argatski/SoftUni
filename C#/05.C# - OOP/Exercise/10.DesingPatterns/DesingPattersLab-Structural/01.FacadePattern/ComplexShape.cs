using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.FacadePattern
{
    internal class ComplexShape : IDrawable
    {
        private List<IDrawable> _shapes = new List<IDrawable>();
        public string Name { get; set; }

        public ComplexShape(string name)
        {
            this.Name = name;
        }

        public void AddChild(IDrawable child)
        {
            _shapes.Add(child);
        }

        public void Draw(int level)
        {
            Console.Write(new string(' ', level));
            Console.WriteLine(Name);

            foreach (var shape in _shapes)
            {
                shape.Draw(level + 3);
            }
        }


    }
}
