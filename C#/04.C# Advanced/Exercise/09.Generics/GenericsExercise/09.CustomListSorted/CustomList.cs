using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomListSorted
{
    public class CustomList<T> : IEnumerable<T>
       where T : IComparable<T>
    {
        //Field
        private List<T> list;
        //Constructor
        public CustomList()
        {
            this.list = new List<T>();
        }
        public CustomList(IEnumerable<T> items)
        {
            this.list = new List<T>(items);
        }

        //Methods
        /// <summary>
        /// Adds the given element to the end of the list.
        /// </summary>
        /// <param name="element"></param>
        public void Add(T element)
        {
            this.list.Add(element);
        }

        /// <summary>
        /// Removes the element at the given index
        /// </summary>
        /// <param name="index"></param>
        public void Remove(int index)
        {
            this.list.RemoveAt(index);
        }
        /// <summary>
        /// Prints if the list contains the given element (True or False)
        /// </summary>
        /// <param name="element"></param>
        public bool Contains(T element)
        {
            return this.list.Contains(element);
        }
        /// <summary>
        /// Swaps the elements at the given indexes
        /// </summary>
        /// <param name="firstIndex"></param>
        /// <param name="secondIndex"></param>
        public void Swap(int firstIndex, int secondIndex)
        {
            CheckIndexOutOfRange(firstIndex);

            var first = list[firstIndex];
            list[firstIndex] = list[secondIndex];
            list[secondIndex] = first;
        }

        /// <summary>
        /// Counts the elements that are greater than the given element and prints their count
        /// </summary>
        /// <param name="element"></param>
        public int Greater(T element)
        {
            int count = list.Count(el => el.CompareTo(element) > 0);
            return count;
        }

        /// <summary>
        /// Prints the maximum element in the list.
        /// </summary>
        /// <returns></returns>
        public T Max()
        {
            return list.Max();
        }

        /// <summary>
        /// Prints the minimum element in the list.
        /// </summary>
        /// <returns></returns>
        public T Min()
        {
            return list.Min();
        }

        /// <summary>
        /// Prints all elements in the list, each on a separate line.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Join(Environment.NewLine, list);
        }

        private void CheckIndexOutOfRange(int index)
        {
            if (index < 0 || index > list.Count)
            {
                throw new IndexOutOfRangeException("Index out of range exception!");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in this.list)
            {
                yield return item;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
}
}
