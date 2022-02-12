using System;
using System.Collections.Generic;
using System.Text;

namespace GenericSwapMethodIntegers
{
    public class Box<T>
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

        /// <summary>
        /// The method swap elements by given indexes.
        /// </summary>
        /// <param name="firstIndex"></param>
        /// <param name="secondIndex"></param>
        /// <returns></returns>
        public List<T> Swap(int firstIndex, int secondIndex)
        {
            var first = this.list[firstIndex];
            this.list[firstIndex] = this.list[secondIndex];
            this.list[secondIndex] = first;

            return this.list;
        }


        //Print result
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in this.list)
            {
                sb.AppendLine($"{item.GetType().FullName}: {item}");
            }

            return sb.ToString();
        }
    }
}
