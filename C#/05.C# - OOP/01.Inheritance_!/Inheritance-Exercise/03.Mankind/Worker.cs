using System;
using System.Collections.Generic;
using System.Text;

namespace Mankind
{
    public class Worker : Human
    {
        //Fields
        private double salary;
        private double perDay;
        private int workweek = 5;

        //Constructor
        public Worker(string firstName, string lastName, double salary, double perDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = salary;
            this.PerDay = perDay;
        }
        //Properties
        public double WeekSalary
        {
            get { return this.salary; }
            set
            {
                if (value <= 10)
                {
                    throw new ArgumentException($"Expected value mismatch! Argument: weekSalary");
                }
                this.salary = value;
            }
        }

        public double PerDay
        {
            get { return this.perDay; }
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException($"Expected value mismatch! Argument: workHourPerDay");
                }
                this.perDay = value;
            }
        }

        //Calculate salary per hour
        private double SalaryPerHour()
        {
            double result = this.WeekSalary / (this.PerDay * this.workweek);

            return result;
        }

        //Print
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("First Name: ").Append(this.FirstName)
                    .Append(Environment.NewLine)
                    .Append("Last Name: ").Append(this.LastName)
                    .Append(Environment.NewLine)
                    .Append(String.Format("Week Salary: {0:F2}", this.WeekSalary))
                    .Append(Environment.NewLine)
                    .Append(String.Format("Hours per day: {0:F2}", this.PerDay))
                    .Append(Environment.NewLine)
                    .Append(String.Format("Salary per hour: {0:F2}", this.SalaryPerHour()));

            return sb.ToString();
        }


    }
}
