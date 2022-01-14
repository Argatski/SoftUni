using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Employee
    {
        //Properties
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }


        //Constructor
        /// <summary>
        /// Default
        /// </summary>
        public Employee()
        {
        }
        /// <summary>
        /// The name, salary, position and department are mandatory.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="salary"></param>
        /// <param name="position"></param>
        /// <param name="department"></param>
        public Employee(string name, double salary, string position, string department) : this()
        {
            Name = name;
            Salary = salary;
            Position = position;
            Department = department;
            Email = @"n/a";
            Age = -1;
        }
        /// <summary>
        /// If an employee doesn’t have an email – in place of that field you should print “n/a” instead.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="salary"></param>
        /// <param name="position"></param>
        /// <param name="department"></param>
        /// <param name="email"></param>
        /// <param name="age"></param>
        public Employee(string name, double salary, string position, string department, int age)
        : this(name, salary, position, department)
        {
            Email = @"n/a";
            Age = age;
        }
        /// <summary>
        /// "If he doesn’t have an age – print “-1” instead."
        /// </summary>
        /// <param name="name"></param>
        /// <param name="salary"></param>
        /// <param name="position"></param>
        /// <param name="departemnet"></param>
        /// <param name="email"></param>
        public Employee(string name, double salary, string position, string departemnet, string email) : this(name, salary, position, departemnet)
        {
            Email = email;
            Age = -1;
        }
        /// <summary>
        /// If all parameters are valid.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="salary"></param>
        /// <param name="position"></param>
        /// <param name="departemnet"></param>
        /// <param name="email"></param>
        public Employee(string name, double salary, string position, string departemnet, string email, int age) : this(name, salary, position, departemnet)
        {
            Email = email;
            Age = age;
        }


    }
}

/*Another solution
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

 */
