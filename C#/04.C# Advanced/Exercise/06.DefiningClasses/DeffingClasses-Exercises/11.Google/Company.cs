using System;
using System.Collections.Generic;
using System.Text;

namespace _11.Google
{
    public class Company
    {
        //Fields
        public string name;
        public string department;
        public decimal salary;

        //Construnctor
        public Company(string name, string department, decimal salary)
        {
            this.name = name;
            this.department = department;
            this.salary = salary;
        }

        //Print format
        public override string ToString()
        {
            return string.Format("{0} {1} {2:F2}", this.name, this.department, this.salary);
        }

    }
}
