using System;
using System.Collections.Generic;
using System.Text;

namespace GenericScale
{
    
    public class EqualityScale<T>
    {
        //Fieald
        private T firstElement;
        private T secondElement;

        //Constructor
        public EqualityScale(T first, T second)
        {
            this.firstElement = first;
            this.secondElement = second;
        }

        /// <summary>
        /// The method should return true if the elements are eauql.
        /// </summary>
        /// <returns></returns>
        public bool AreEqual()
        {
            return this.firstElement.Equals(this.secondElement);
        }
    }
    
}
