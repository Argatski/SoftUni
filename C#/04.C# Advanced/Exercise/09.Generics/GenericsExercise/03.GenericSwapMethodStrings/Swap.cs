using System;
using System.Collections.Generic;
using System.Text;

namespace GenericSwapMethodStrings
{
    class Swap<T>
    {
        //Field
        private List<T> list;

        public Swap()
        {
            this.list = new List<T>();
        }

        public void Add(T element)
        {
            list.Add(element);
        }

        /// <summary>
        /// Use the method you've created to swap the elements that correspond to the given indexes and print each element in the list.
        /// </summary>
        /// <param name="firstIndex"></param>
        /// <param name="secondIndex"></param>
        /// <returns></returns>
        public List<T> SwapString(int firstIndex, int secondIndex)
        {
            var first = list[firstIndex];
            list[firstIndex] = list[secondIndex];
            list[secondIndex] = first;

            return list;
        }

        //Print 
        public void Print()
        {
            foreach (var item in list)
            {
                Console.WriteLine($"{item.GetType().FullName}: {item}");
            }
        }
    }
}
