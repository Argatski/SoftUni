using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDoublyLinkedList
{
    public class DoublyLinkedList
    {
        //Field
        private class ListNode
        {
            //Properties
            public int Value { get; }
            public ListNode NextNode { get; set; }
            public ListNode PreviousNode { get; set; }

            //Constructor
            public ListNode(int value)
            {
                Value = value;
            }

        }

        //Fields
        private ListNode head;
        private ListNode tail;

        //Properites
        public int Count { get; private set; }

        /// <summary>
        /// Adds an element at the beginning of the collection
        /// </summary>
        /// <param name="element"></param>
        public void AddFirst(int element)
        {
            ListNode newHead = new ListNode(element);

            if (this.Count == 0)
            {
                head = newHead;
                tail = newHead;
            }
            else
            {
                newHead.NextNode = this.head;
                head.PreviousNode = newHead;
                head = newHead;
            }
            Count++;
        }

        /// <summary>
        /// Adds an element at the end of the collection.
        /// </summary>
        /// <param name="element"></param>
        public void AddLast(int element)
        {
            if (Count == 0)
            {
                tail = head = new ListNode(element);
            }
            else
            {
                var newTail = new ListNode(element);
                newTail.PreviousNode = tail;
                tail.NextNode = newTail;
                tail = newTail;
            }
            Count++;
        }

        /// <summary>
        /// Removes the element at the beginning of the collection
        /// </summary>
        /// <returns></returns>
        public int RemoveFirst()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("The list is empty");
            }

            //If doublyLinkedList have single element in the list.
            var firstElement = head.Value;
            head = head.NextNode; //get next 
            if (head == null)
            {
                tail = null;
            }
            //More than a single element
            else
            {
                head.PreviousNode = null;
            }
            Count--;
            return firstElement;
        }

        /// <summary>
        /// Removes the element at the end of the collection
        /// </summary>
        /// <returns></returns>
        public int RemoveLast()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("The list is empty");
            }

            //If doublyLinkedList have single element in the list.
            var lastElement = tail.Value;
            tail = tail.PreviousNode;//get previos value
            if (tail == null)
            {
                head = null;
            }
            //More than a single element
            else
            {
                tail.NextNode = null;
            }
            Count--;
            return lastElement;
        }

        /// <summary>
        /// Goes through the collection and executes a given action
        /// </summary>
        /// <param name=""></param>
        public void ForEach(Action<int> action)
        {
            var currenNode = head;
            while (currenNode != null)
            {
                action(currenNode.Value);
                currenNode = currenNode.NextNode;
            }
        }

        public int[] ToArray()
        {
            int[] array = new int[Count];
            int counter = 0;

            var currentNode = head;
            while (currentNode != null)
            {
                array[counter++] = currentNode.Value;
                currentNode = currentNode.NextNode;
            }

            return array;
        }

    }
}
