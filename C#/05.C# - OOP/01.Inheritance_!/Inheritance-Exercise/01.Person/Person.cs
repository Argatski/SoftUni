using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Person
{
    public class Person
    {
        //Fields
        private string name;
        private int age;

        //Constructor
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        //Proprties
        public string Name { get { return this.name; } set { this.name = value; } }
        public virtual int Age
        {
            get { return this.age; }
            set //People should not be able to have a negative age
            {
                if (value < 0)
                {
                    throw new ArgumentException("People should not be able to have a negative age");
                }
                this.age = value;
            }
        }

        public override string ToString()
        {
            /*StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(String.Format("Name: {0}, Age: {1}",
                                 this.Name,
                                 this.Age));

            return stringBuilder.ToString();*/

            return $"Name: {this.Name}, Age: {this.Age}";

        }
    }
}
