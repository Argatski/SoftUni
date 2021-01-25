using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Students2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            List<Students> students = new List<Students>();

            while (line != "end")
            {
                string[] tokens = line.Split();

                string firstName = tokens[0];
                string secondName = tokens[1];
                string age = tokens[2];
                string town = tokens[3];

                Students stud = students.FirstOrDefault(s => s.FirstName == firstName && s.LastName == secondName);

                if (stud == null)
                {
                    students.Add(new Students()
                    {
                        FirstName = firstName,
                        LastName = secondName,
                        Age = age,
                        Town = town

                    });
                }
                else
                {
                    stud.FirstName = firstName;
                    stud.LastName = secondName;
                    stud.Age = age;
                    stud.Town = town;
                }


                //Another solution
                //if (IsStudentExsting(students, firstName, secondName))
                //{
                //    Students stud = GetStudent(students, firstName, secondName);

                //    stud.FirstName = firstName;
                //    stud.LastName = secondName;
                //    stud.Age = age;
                //    stud.Town = town;

                //}
                //else
                //{
                //    Students student = new Students()
                //    {
                //        FirstName = firstName,
                //        LastName = secondName,
                //        Age = age,
                //        Town = town
                //    };
                //    students.Add(student);
                //}


                line = Console.ReadLine();
            }

            string sity = Console.ReadLine();

            List<Students> printName = students.Where(x => x.Town == sity).ToList();

            foreach (Students st in printName)
            {
                Console.WriteLine($"{st.FirstName} {st.LastName} is {st.Age} years old.");
            }
        }

        static Students GetStudent(List<Students> students, string firstName, string secondName)
        {
            Students existingSutdent = null;
            foreach (Students st in students)
            {
                if (st.FirstName == firstName && st.LastName == secondName)
                {
                    existingSutdent = st;
                }
            }
            return existingSutdent;
        }

        static bool IsStudentExsting(List<Students> students, string firstName, string secondName)
        {
            foreach (Students stud in students)
            {
                if (stud.FirstName == firstName && stud.LastName == secondName)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
