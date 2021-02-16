using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int numberOfStudent = int.Parse(Console.ReadLine());

            //Solution
            List<Student> students = new List<Student>();

            StudentDictinary(students, numberOfStudent);
            //Print solution array

            students = students.OrderBy(x => x.Grade).Reverse().ToList();

            Console.WriteLine(string.Join(Environment.NewLine, students));

        }

        static List<Student> StudentDictinary(List<Student> list, int num)
        {

            for (int i = 0; i < num; i++)
            {
                string[] person = Console.ReadLine().Split(" ");

                string firstName = person[0];
                string secondtName = person[1];
                double grade = double.Parse(person[2]);

                Student student = new Student(firstName, secondtName, grade);

                list.Add(student);
            }

            return list;
        }

        //class Student
        //{
        //    public string FirstName { get; set; }
        //    public string SecondName { get; set; }
        //    public double Grade { get; set; }

        //    public Student(string firstName, string secondName, double grade)
        //    {
        //        FirstName = firstName;
        //        SecondName = secondName;
        //        Grade = grade;
        //    }


        //    public override string ToString()
        //    {
        //        return $"{FirstName} {SecondName}: {Grade:f2}";
        //    }
        //}
    }
}
