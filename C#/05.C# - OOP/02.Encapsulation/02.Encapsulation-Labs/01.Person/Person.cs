﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo 
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
        public string FirstName
        {
            get { return this.firstName; }
            private set
            {
                this.firstName = value;
            }
        }
        public string LastName
        {
            get { return this.lastName; }
            private set
            {
                this.lastName = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                this.age = value;
            }
        }

        //Methods
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.FirstName} {this.lastName} is {this.Age} years old.");

            return sb.ToString();
        }
    }
}
