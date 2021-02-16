using System;
using System.Collections.Generic;
using System.Text;

namespace _04.Students
{
    class Student
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public double Grade { get; set; }

        public Student(string firstName,string secondName, double grade)
        {
            FirstName = firstName;
            SecondName = secondName;
            Grade = grade;
        }


        public override string ToString()
        {
            return $"{FirstName} {SecondName}: {Grade:f2}"; 
        }
    }
}
