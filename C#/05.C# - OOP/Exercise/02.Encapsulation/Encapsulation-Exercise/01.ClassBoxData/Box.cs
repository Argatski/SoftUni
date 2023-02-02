using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBoxData
{
    public class Box
    {
        //Fields
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }
        public double Length
        {
            get { return this.length; }
            private set
            {
                ZeroOrNegative("Length", value);
                this.length = value;
            }
        }
        public double Width
        {
            get { return this.width; }
            private set
            {
                ZeroOrNegative("Width", value);
                this.width = value;
            }
        }
        public double Height
        {
            get { return this.height; }
            private set
            {
                ZeroOrNegative("Height", value);
                this.height = value;
            }
        }

        /// <summary>
        /// If one of the properties is a zero or negative number throw ArgumentException with the message: "{propertyName} cannot be zero or negative."
        /// </summary>
        /// <param name="length"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        private static void ZeroOrNegative(string name, double value)
        {
            if (value < 0)
            {
                throw new ArgumentException($"{name} cannot be zero or negative.");
            }
        }
        /// <summary>
        /// Calculate and return the surface area of the Box.
        /// </summary>
        /// <returns></returns>
        public double SurfaceArea()
        {
            double surfaceArea = 2 * (this.Height * this.Width + this.Width * this.Length + this.Height * this.Length);

            return surfaceArea;
        }
        /// <summary>
        /// Calculate and return the lateral surface area of the Box.
        /// </summary>
        /// <returns></returns>
        public double LateralSurfaceArea()
        {
            double lateralSurfaceArea = 2 * this.Height * (this.Length + this.Width);
            return lateralSurfaceArea;
        }
        /// <summary>
        /// Calculate and return the volume of the Box
        /// </summary>
        /// <returns></returns>
        public double Volume()
        {
            double volume = this.Height * this.Length * this.Width;
            return volume;
        }
    }
}
