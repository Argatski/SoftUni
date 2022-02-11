using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxOfInteger
{
    class Box<T>
    {
        //Field
        private T value;

        //Constructor
        public Box(T value)
        {
            this.value = value;
        }

        //Print
        public override string ToString()
        {
            return $"{this.value.GetType().FullName}: {this.value}"; 
        }
    }
}
