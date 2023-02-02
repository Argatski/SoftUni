using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Circle : Shape
    {
        private double radius;
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get { return this.radius; }
            private set
            {
                this.ValidateRadiusException(value);
                this.radius = value;
            }
        }

        private void ValidateRadiusException(double value)
        {
            if (value <= 0)
            {
                throw new InvalideRadiusException();
            }
        }

        public override double CalculateArea()
        {
            double area = Math.PI * Math.Pow(this.radius, 2);
            return Math.Round(area, 2);
        }

        public override double CalculatePerimeter()
        {
            double perimeter = 2 * Math.PI * this.radius;
            return Math.Round(perimeter, 2);
        }

        public override string Draw()
        {
            return base.Draw() + $" {this.GetType().Name}";
        }
    }
}
