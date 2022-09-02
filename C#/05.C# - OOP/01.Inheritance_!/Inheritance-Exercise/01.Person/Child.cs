using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Person
{
    public class Child : Person
    {

        //Constructor
        public Child(string name, int age)
            : base(name, age)
        {

        }


        /// <summary>
        /// Method override Base Age.
        /// </summary>
        public override int Age
        {
            get
            {
                return base.Age;
            }
            set
            {
                if (value > 15)
                {
                    throw new ArgumentException("Children should not be able to have an age greater than 15");
                }
                base.Age = value;
            }
        }
    }
}
