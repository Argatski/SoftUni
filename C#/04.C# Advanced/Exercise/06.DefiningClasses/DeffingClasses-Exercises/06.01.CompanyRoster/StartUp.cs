using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //Input 
            int number = int.Parse(Console.ReadLine());

            //Create list of Employee.
            List<Employee> employees = new List<Employee>();

            //Best department
            HashSet<string> best = new HashSet<string>();

            //Read input
            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);


                string name = input[0];
                double salary = double.Parse(input[1]);
                string position = input[2];
                string department = input[3];

                string email = string.Empty;
                int age = 0;

                //Instance
                Employee employee = new Employee();

                if (input.Length == 5)
                {
                    if (input[4].Contains("@"))
                    {
                        email = input[4];
                        employee = new Employee(name, salary, position, department, email);
                    }
                    else
                    {
                        age = int.Parse(input[4]);
                        employee = new Employee(name, salary, position, department, age);
                    }

                }
                else if (input.Length == 6)
                {
                    email = input[4];
                    age = int.Parse(input[5]);
                    employee = new Employee(name, salary, position, department, email, age);
                }
                else
                {
                    employee = new Employee(name, salary, position, department);
                }

                employees.Add(employee);
                best.Add(department);
            }
            //Get the department with the highest average salary.
            string bestDepartment = GetDepartment(best, employees);

            //Prints for each employee in that department. 
            Console.WriteLine($"Highest Average Salary: {bestDepartment}");

            employees = employees.Where(d => d.Department == bestDepartment)
                .OrderByDescending(s => s.Salary).ToList();
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:f2} {employee.Email} {employee.Age}");
            }
        }

        /// <summary>
        /// Calculates the department with the highest average salary and prints for each employee in that department 
        /// </summary>
        /// <param name="best"></param>
        /// <param name="employees"></param>
        /// <returns></returns>
        private static string GetDepartment(HashSet<string> best, List<Employee> employees)
        {
            string bestDepartment = string.Empty;
            double bestSlary = double.MinValue;

            foreach (var department in best)
            {
                double avarege = employees
                    .Where(x => x.Department == department)
                    .Select(a => a.Salary)
                    .Average();

                if (avarege > bestSlary)
                {
                    bestDepartment = department;
                    bestSlary = avarege;
                }

            }
            return bestDepartment;
        }

    }
}
