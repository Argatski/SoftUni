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

        //Swap
        public List<T> SwapString(int firstIndex, int secondIndex)
        {
            var first = list[firstIndex];
            list[firstIndex] = list[secondIndex];
            list[secondIndex] = first;

            return list;
        }


        /// <summary>
        /// If collection is empty
        /// </summary>
        private void ChekckIfEmpty()
        {
            if (this.list.Count == null)
            {
                throw new InvalidOperationException("Collection is empty!");
            }
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
