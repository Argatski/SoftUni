using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomList
{
    public class CustomList<T>
        where T : IComparable<T>
    {
        //Field
        private T[] array;
        private const int lenght = 2;

        public int Count { get; private set; }

        //Constructor
        public CustomList()
        {
            this.array = new T[lenght];
            this.Count = 0;
        }

        //Methods
        /// <summary>
        /// Adds the given element to the end of the list
        /// </summary>
        /// <param name="element"></param>
        public void Add(T element)
        {
            if (Count == this.array.Length)
            {
                ResizeList();
            }

            this.array[Count] = element;
            Count++;

        }

        /// <summary>
        /// Removes the element at the given index
        /// </summary>
        /// <param name="index"></param>
        public void Remove(int index)
        {
            CheckIndexOutOfrange(index);
            ShiftLeft(index);
            Shrink();

            this.Count--;
        }

        /// <summary>
        /// Prints if the list contains the given element (True or False).
        /// </summary>
        /// <param name="element"></param>
        public bool Contains(T element)
        {
            bool isTrue = this.array.Contains(element);
            return isTrue;
        }

        /// <summary>
        /// Swaps the elements at the given indexes
        /// </summary>
        /// <param name="index"></param>
        /// <param name="index2"></param>
        public void Swap(int index, int index2)
        {
            CheckIndexOutOfrange(index);
            CheckIndexOutOfrange(index2);

            var firstElement = this.array[index];
            this.array[index] = this.array[index2];
            this.array[index2] = firstElement;
        }

        /// <summary>
        /// Counts the elements that are greater than the given element and prints their count
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public int Greater(T element)
        {
            int num = 0;

            for (int i = 0; i < Count; i++)
            {
                if (this.array[i].CompareTo(element) > 0)
                {
                    num++;
                }
            }
            return num;

        }

        /// <summary>
        /// Prints the maximum element in the list.
        /// </summary>
        /// <returns></returns>
        public T Max()
        {
            return this.array.Max();
        }
        /// <summary>
        /// Prints the minimum element in the list
        /// </summary>
        /// <returns></returns>
        public T Min()
        {
            return this.array.Min();
        }

        /// <summary>
        /// Prints all elements in the list, each on a separate line
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            /*for (int i = 0; i < Count; i++)
            {
                if (this.array[i] != null)
                {
                    sb.AppendLine($"{this.array[i]}");
                }
            }
            return sb.ToString();*/

            return String.Join(Environment.NewLine, this.array);
        }



        private void Shrink()
        {
            if (this.array.Length / 4 > this.Count)
            {
                T[] copy = new T[this.array.Length / 4];

                for (int i = 0; i < Count; i++)
                {
                    copy[i] = this.array[i];
                }

                this.array = copy;
            }
        }

        private void ShiftLeft(int index)
        {
            if (index < this.Count - 1)
            {
                for (int i = index; i < this.Count - 1; i++)
                {
                    this.array[i] = this.array[i + 1];
                }
            }
            this.array[Count - index] = default;
        }

        /// <summary>
        /// If the array lenght < count
        /// </summary>
        private void ResizeList()
        {
            T[] copy = new T[this.array.Length * 2];

            for (int c = 0; c < Count; c++)
            {
                copy[c] = this.array[c];
            }

            this.array = copy;
        }
        private void CheckIndexOutOfrange(int index)
        {
            if (index < 0 || index > Count)
            {
                throw new IndexOutOfRangeException("Index out of range!");
            }
        }
    }

    //Another Solution
    /*
    public class CustomList<T>
    where T : IComparable<T>
    {
        private List<T> data;

        public CustomList()
        {
            this.data = new List<T>();
        }

        public void Add(T element)
        {
            this.data.Add(element);
        }

        public T Remove(int index)
        {
            T element = this.data[index];
            this.data.RemoveAt(index);

            return element;
        }

        public bool Contains(T element)
        {
            return this.data.Contains(element);
        }

        public void Swap(int index1, int index2)
        {
            T temp = this.data[index1];
            this.data[index1] = this.data[index2];
            this.data[index2] = temp;
        }

        public int CountGreaterThan(T element)
        {
            return this.data.Count(e => e.CompareTo(element) > 0);
        }

        public T Max()
        {
            return this.data.Max();
        }

        public T Min()
        {
            return this.data.Min();
        }

        public override string ToString()
        {
            return String.Join(Environment.NewLine, this.data);
        }
    }*/
}
