using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    class Employee
    {
        //This properties are mandatory
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }


        //This properties are optional
        public string Email { get; set; }
        public int Age { get; set; }


        public Employee(string name, double salary, string position, string department,string email,int age)
        {
            Name = name;
            Salary = salary;
            Position = position;
            Department = department;
            Email = email;
            Age = age;
        }

    }
}
