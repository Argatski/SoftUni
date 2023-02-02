using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Rectangle : Shape
    {
        private const string InvalidSideExceptionsMessage = "{0} must be a positive number!";

        private double height;
        private double width;
        public Rectangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public double Height
        {
            get { return this.height; }
            private set
            {
                this.ValideteSide(value, nameof(this.Height));
                this.height = value;
            }
        }

        public double Width
        {
            get { return this.width; }
            private set
            {
                this.ValideteSide(value, nameof(this.Width));
                this.width = value;
            }
        }

        private void ValideteSide(double value, string sideName)
        {
            if (value <= 0)
            {
                throw new InvalidSideExceptions(string.Format(InvalidSideExceptionsMessage, sideName));
            }
        }

        public override double CalculateArea()
        {
            return height * width;
        }

        public override double CalculatePerimeter()
        {
            return 2 * height + 2 * width;
        }
        public override string Draw()
        {
            return base.Draw() + $" {this.GetType().Name}";
        }
    }
}
