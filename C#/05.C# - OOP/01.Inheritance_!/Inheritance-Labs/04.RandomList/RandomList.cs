using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    public class RandomList : List<string> //Inheritance RandomList-> List<string>
    {
        //Field
        private Random rnd;

        //Constructor
        public RandomList()
        {
            rnd = new Random();
        }

        /// <summary>
        /// Function that returns and removes a random element from the list
        /// </summary>
        /// <returns></returns>
        public string RanodomString()
        {

            int index = rnd.Next(0, this.Count);

            string result = string.Empty;
            result = this[index];
            this.RemoveAt(index);

            return result;
        }
    }
}
