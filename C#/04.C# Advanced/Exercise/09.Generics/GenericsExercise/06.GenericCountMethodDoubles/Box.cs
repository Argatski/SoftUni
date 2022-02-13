using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCountMethodDoubles
{
    public class Box<T> : IComparable<T>
        where T : IComparable<T>
    {
        private T element;

        //Constructor
        public Box(T value)
        {
            element = value;
        }

        //CompareTo elements
        public int CompareTo(T value)
        {
            return element.CompareTo(value);
        }
    }
}
