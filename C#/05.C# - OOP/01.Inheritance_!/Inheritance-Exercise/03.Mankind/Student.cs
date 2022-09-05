using System;
using System.Collections.Generic;
using System.Text;

namespace Mankind
{
    public class Student : Human
    {
        //Fields
        private string facultyNumber;

        //Constructor
        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }
        //Properties
        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            set
            {
                if (value.Length < 5 || value.Length > 10)
                {
                    throw new ArgumentException("Invalid faculty number!");
                }
                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("First Name: ").Append(this.FirstName)
                    .Append(Environment.NewLine)
                    .Append("Last Name: ").Append(this.LastName)
                    .Append(Environment.NewLine)
                    .Append("Faculty number: ")
                    .Append(this.FacultyNumber);

            return sb.ToString();
        }
    }
}
