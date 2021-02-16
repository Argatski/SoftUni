using System;
using System.Collections.Generic;
using System.Linq;
namespace _07.StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> averageGrade = new Dictionary<string, List<double>>();

            //Solution
            Processing(n, averageGrade);

            //Sort and print
            var sortResult = SortByAvarage(averageGrade);
            
            PrintStudentList(sortResult);

        }

        static Dictionary<string, double> SortByAvarage(Dictionary<string, List<double>> average)
        {
            Dictionary<string, double> result = new Dictionary<string, double>();

            foreach (var kvp in average)
            {
                double avaregeGrade = kvp.Value.Sum() / kvp.Value.Count();

                result.Add(kvp.Key, avaregeGrade);
            }

            result = result.OrderByDescending(g => g.Value)
                .ToDictionary(k => k.Key, v => v.Value);

            return result;
        }

        static void PrintStudentList(Dictionary<string,double> result)
        {
            foreach (var kvp in result)
            {
                if (kvp.Value>=4.50)
                {
                    Console.WriteLine($"{kvp.Key} -> {kvp.Value:f2}");
                }
            }
        }

        static void Processing(int n, Dictionary<string, List<double>> list)
        {
            for (int i = 0; i < n; i++)
            {
                string student = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (list.ContainsKey(student))
                {
                    list[student].Add(grade);
                }
                else
                {
                    list.Add(student, new List<double>() { grade });
                }

            }
        }
    }
}
