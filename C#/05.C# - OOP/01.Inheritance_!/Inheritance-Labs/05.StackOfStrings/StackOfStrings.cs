using System;
using System.Collections.Generic;
using System.Text;

namespace CustomStack
{
    public class StackOfStrings : Stack<string>
    {
        /// <summary>
        /// Is empty stack.
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return this.Count == 0;
        }


        /// <summary>
        /// Add randge
        /// </summary>
        /// <param name="collection"></param>
        public void AddRange(IEnumerable<string> collection)
        {
            foreach (var elemet in collection)
            {
                this.Push(elemet);
            }
        }

    }
}
