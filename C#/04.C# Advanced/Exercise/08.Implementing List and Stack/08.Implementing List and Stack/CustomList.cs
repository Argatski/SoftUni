using System;
using System.Collections.Generic;
using System.Text;

namespace _08.Implementing_List_and_Stack
{
    class CustomList
    {
        //Fields
        private int[] array;
        private const int capacity = 2;

        public CustomList()
        {
            this.array = new int[capacity];
        }

        public int Count { get; private set; }

        public int this[int index]
        {
            get
            {
                IsValidIndex(index);

                return array[index];
            }
            set
            {

                array[index] = value;
            }
        }

        /// <summary>
        /// Adds a new elements to the end of our collection
        /// </summary>
        /// <param name="element"></param>
        public void Add(int element)
        {
            if (this.Count == array.Length)
            {
                this.Resize();
            }
            this.array[this.Count] = element;
            this.Count++;
        }
        public int RemoveAt(int index)
        {
            this.IsValidIndex(index);

            var item = this.array[index];
            this.array[index] = default;

            this.Shift(index);
            this.Count--;

            if (this.Count <= this.array.Length / 4)
            {
                this.Shirink();

            }
            return item;
        }

        /// <summary>
        /// Insert a given number in a given position (index).
        /// </summary>
        /// <param name="index"></param>
        /// <param name="number"></param>
        public void Insert(int index, int number)
        {
            if (index > this.Count)
            {
                throw new ArgumentException("Invalid index");
            }

            if (this.Count == this.array.Length)
            {
                Resize();
            }
            this.ShiftToRight(index);

            this.array[index] = number;
            this.Count++;
        }

        /// <summary>
        /// This method should check if the given element is in the collection.
        /// </summary>
        /// <param name="element"></param>
        public bool Contains(int element)
        {
            for (int i = 0; i < Count; i++)
            {
                var currentElement = this.array[i];
                if (element == currentElement)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Swap the elements to the first index and second index.
        /// </summary>
        /// <param name="firstIndex"></param>
        /// <param name="secondIndex"></param>
        public void Swap(int firstIndex, int secondIndex)
        {
            IsValidIndex(firstIndex);
            IsValidIndex(secondIndex);

            var first = this.array[firstIndex];
            this.array[firstIndex] = this.array[secondIndex];
            this.array[secondIndex] = first;
        }

        /// <summary>
        /// Reverse array
        /// </summary>
        public void Reverse()
        {
            int[] copy = new int[this.Count];

            for (int i = this.Count - 1; i >= 0; i--)
            {
                copy[this.Count - i - 1] = this.array[i];
            }
            this.array = copy;
        }

        /// <summary>
        /// Returns a string that represents the current object. 
        /// </summary>
        /// <returns></returns>
        public string Tostring()
        {
            string result = string.Empty;

            for (int i = 0; i < this.Count; i++)
            {
                result += this.array[i] + " ";
            }

            return result.TrimEnd();
        }

        //Private methods

        /// <summary>
        /// Shift all elements to the right from a given index.
        /// </summary>
        /// <param name="index"></param>
        private void ShiftToRight(int index)
        {
            for (int i = Count; i >= index; i--)
            {
                this.array[i] = this.array[i - 1];
            }
        }

        /// <summary>
        /// The method reduces the array lenght twice.
        /// </summary>
        private void Shirink()
        {
            int[] copy = new int[this.array.Length / 2];

            for (int i = 0; i < this.Count; i++)
            {
                copy[i] = this.array[i];
            }
            this.array = copy;
        }

        /// <summary>
        /// The method use loop which moves all the elements to the left startin from a given index.
        /// </summary>
        /// <param name="index"></param>
        private void Shift(int index)
        {
            for (int i = index; i < this.Count - 1; i++)
            {
                this.array[i] = this.array[i + 1];
            }
            this.array[this.Count - 1] = default;
        }

        /// <summary>
        /// Is it a valid index?
        /// </summary>
        /// <param name="index"></param>
        private void IsValidIndex(int index)
        {
            if (index >= this.Count)
            {
                throw new ArgumentException("Invalid index");
            }
        }

        /// <summary>
        /// Resize our list.
        /// </summary>
        private void Resize()
        {
            int[] copy = new int[this.array.Length * 2];
            for (int i = 0; i < array.Length; i++)
            {
                copy[i] = array[i];
            }
            this.array = copy;
        }
    }
}
