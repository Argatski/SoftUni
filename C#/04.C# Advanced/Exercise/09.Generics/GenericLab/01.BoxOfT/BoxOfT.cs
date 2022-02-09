using System;
using System.Collections.Generic;

namespace BoxOfT
{
    public class Box<T> //If we have<> that mean is generics
    {
        //Field
        private Stack<T> list; // We can use List<T> but is slow if elements are more.

        //Propertie
        public int Count { get; private set; }

        public Box()
        {
            list = new Stack<T>();
        }

        //Mehtods
        /// <summary>
        /// Adds an element on the top of list
        /// </summary>
        /// <param name="element"></param>
        public void Add(T element)
        {
            list.Push(element);
            Count++;
        }

        //Removes the topmost element.
        public T Remove()
        {
            return list.Pop();
        }
    }
}

