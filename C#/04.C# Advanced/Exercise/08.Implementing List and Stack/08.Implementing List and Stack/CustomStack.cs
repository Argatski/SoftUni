using System;
using System.Collections.Generic;
using System.Text;

namespace _08.Implementing_List_and_Stack
{
    public class CustomStack
    {
        private int[] array;
        private const int capacity = 4;

        public int Count { get; private set; }

        //Constructor
        public CustomStack()
        {
            this.array = new int[capacity];
        }

        /// <summary>
        /// The Pop() method returns the last element form the collection and removes 
        /// </summary>
        /// <returns></returns>
        public int Pop()
        {
            Validation();

            if (this.Count == this.array.Length / 2)
            {
                this.Shrink();
            }

            int lastIndex = this.Count - 1;
            int current = this.array[lastIndex];

            this.array[lastIndex] = default;
            Count--;
            return current;
        }

        /// <summary>
        /// This method goes through every element from the collection and executes the given action.
        /// </summary>
        /// <param name="action"></param>
        public void ForEach(Action<object> action)
        {
            for (int i = 0; i < this.Count; i++)
            {
                action(this.array[i]);
            }
        }

        /// <summary>
        /// Method returns the last element from the collection, but it doesn't remove it. 
        /// </summary>
        /// <returns></returns>
        public int Peek()
        {
            Validation();

            int lastPosition = this.Count - 1;
            int lastElement = this.array[lastPosition];
            return lastElement;

        }

        /// <summary>
        /// This method adds an element to the end of the collection.
        /// </summary>
        /// <param name="element"></param>
        public void Push(int element)
        {
            if (this.Count == this.array.Length)
            {
                this.Resize();
            }

            this.array[Count] = element;
            this.Count++;
        }

        //If stack is empty throw
        private void Validation()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("CustomStack is empty");
            }
        }

        /// <summary>
        /// Shrink array if count equal length divide 4.
        /// </summary>
        private void Shrink()
        {
            int[] copy = new int[array.Length / 2];
            Array.Copy(this.array, copy, array.Length / 2);

            this.array = copy;
        }

        /// <summary>
        /// Resize stack if count equal length.
        /// </summary>
        private void Resize()
        {
            int[] copy = new int[array.Length * 2];
            Array.Copy(this.array, copy, this.Count);

            this.array = copy;
        }
    }
}
