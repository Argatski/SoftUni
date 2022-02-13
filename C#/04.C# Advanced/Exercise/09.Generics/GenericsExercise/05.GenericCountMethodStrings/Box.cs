using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCountMethodStrings
{
    public class Box<T>
        where T : IComparable<T>
    {
        //Field
        private List<T> list;

        //Constructor
        public Box()
        {
            this.list = new List<T>();
        }

        //Add
        public void Add(T element)
        {
            this.list.Add(element);
        }

        //The method should return the count of elements that are greater than the value of the given element.
        public int GetCount(T value)
        {
            int count = 0;

            foreach (var item in this.list)
            {
                if (item.CompareTo(value) > 0)
                {
                    count++;
                }
            }

            return count;
        }

    }
}
