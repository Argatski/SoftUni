using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AvaregeStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> grades = new Dictionary<string, List<decimal>>();

            //Processing
            Processing(n, grades);

            //Print
            PrintGrades(grades);
        }

        private static void PrintGrades(Dictionary<string, List<decimal>> grades)
        {
            foreach (var name in grades)
            {
                Console.Write($"{name.Key} -> ");

                decimal average = average = name.Value.Average();
                foreach (var grade in name.Value)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.WriteLine($"(avg: {average:f2})");
            }
        }

        static void Processing(int n, Dictionary<string, List<decimal>> grades)
        {
            for (int i = 0; i < n; i++)
            {
                string[] student = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = student[0];
                decimal grade = decimal.Parse(student[1]);

                if (grades.ContainsKey(name) == false)
                {
                    grades.Add(name, new List<decimal>());
                }

                grades[name].Add(grade);
            }
        }
    }
}
