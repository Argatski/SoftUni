using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
        public Person(string firstName, string lastName, int age, decimal salary)
            : this(firstName, lastName, age)
        {
            this.Salayr = salary;
        }
        //Properties
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                this.firstName = value;
            }
        }
        public string LastName
        {
            get { return this.lastName; }
            private set { this.lastName = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public decimal Salayr
        {
            get { return this.salary; }
            private set
            {

                this.salary = value;

            }
        }

        public void IncreaseSalary(decimal percentage)
        {
            if (this.age <= 30)
            {
                this.Salayr += Salayr * percentage / 200;
            }
            else
            {
                this.Salayr += Salayr * percentage / 100;
            }

        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.lastName} receives {this.Salayr:f2} leva.";
        }
    }
}
