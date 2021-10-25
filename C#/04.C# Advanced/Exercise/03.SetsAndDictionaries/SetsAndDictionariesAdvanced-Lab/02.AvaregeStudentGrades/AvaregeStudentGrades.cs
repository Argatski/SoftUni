using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AvaregeStudentGrades
{
    class AvaregeStudentGrades
    {
        static void Main(string[] args)
        {
            //Input
            int numbers = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();

            //Processing
            AvaregeGrades(numbers, students);

            //Print result
            Print(students);

        }

        /// <summary>
        /// Print result
        /// </summary>
        /// <param name="students"></param>
        static void Print(Dictionary<string, List<decimal>> students)
        {
            foreach (var name in students)
            {
                Console.Write($"{name.Key} -> ");

                decimal avaregGrade = name.Value.Average();

                foreach (var grade in name.Value)
                {
                    Console.Write($"{grade:f2} ");
                }

                Console.WriteLine($"(avg: {avaregGrade:f2})");
            }
        }

        /// <summary>
        /// AvaregeGrades
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="students"></param>
        static void AvaregeGrades(int numbers, Dictionary<string, List<decimal>> students)
        {
            for (int i = 0; i < numbers; i++)
            {
                string[] currentStudent = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = currentStudent[0];
                decimal grade = (decimal.Parse)(currentStudent[1]);

                if (students.ContainsKey(name) == false)
                {
                    students.Add(name, new List<decimal>());
                }
                students[name].Add(grade);
            }
        }
    }
}
