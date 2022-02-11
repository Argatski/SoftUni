using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxOfString
{
    public class Box<T>
    {
        //Field
        private T text;

        //Constructors
        public Box(T text)
        {
            this.text = text;
        }

        //Print
        public override string ToString()
        {
            return $"{this.text.GetType().FullName}: {this.text}";
        }
    }
}
