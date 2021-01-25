using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Students> list = new List<Students>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(" ");

                if (input[0] == "end")
                {
                    break;
                }

                string firstName = input[0];
                string secondName = input[1];
                string age = input[2];
                string town = input[3];

                Students student = new Students();//classe

                // Differet Way
                //Students student = new Students()
                //{
                //    FirstName = firstName,
                //    LastName = secondName,
                //    Age = age,
                //    HomeTown = town

                //};

                student.FirstName = firstName;
                student.LastName = secondName;
                student.Age = age;
                student.HomeTown = town;

                list.Add(student);
            }

            string filterTown = Console.ReadLine();

            List<Students> filterList = list
                .Where(x => x.HomeTown == filterTown).ToList();

            foreach (Students stud in filterList)
            {
                Console.WriteLine($"{stud.FirstName} {stud.LastName} is {stud.Age} years old.");
            }

        }
    }
}
