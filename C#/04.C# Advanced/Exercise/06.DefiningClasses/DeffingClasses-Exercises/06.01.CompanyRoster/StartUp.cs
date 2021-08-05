using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //Input lines 
            int number = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            HashSet<string> departments = new HashSet<string>();

            for (int i = 0; i < number; i++)
            {
                string[] argummets = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = argummets[0];
                double salary = double.Parse(argummets[1]);
                string namePosition = argummets[2];
                string department = argummets[3];

                if (argummets.Length == 4)
                {
                    Employee employee = new Employee(name, salary, namePosition, department, @"n/a", -1);

                    employees.Add(employee);
                }
                if (argummets.Length == 5)
                {
                    string currentValue = argummets[4];
                    int age;

                    bool success = int.TryParse(currentValue, out age);

                    if (success)
                    {
                        Employee employee = new Employee(name, salary, namePosition, department, @"n/a", age);
                        employees.Add(employee);
                    }
                    else
                    {
                        Employee employee = new Employee(name, salary, namePosition, department, currentValue, -1);
                        employees.Add(employee);

                    }
                }
                else if (argummets.Length > 5)
                {
                    string email = argummets[4];
                    int age = int.Parse(argummets[5]);

                    Employee employee = new Employee(name, salary, namePosition, department, email, age);
                    employees.Add(employee);
                }

                departments.Add(department);

            }

            string bestDepartment = GetBestDepartment(departments, employees);

            Console.WriteLine($"Highest Average Salary: {bestDepartment}");

            foreach (var emp in employees.Where(x => x.Department == bestDepartment).OrderByDescending(s => s.Salary))
            {
                Console.WriteLine($"{emp.Name} {emp.Salary:F2} {emp.Email} {emp.Age}");
            }
        }

        private static string GetBestDepartment(HashSet<string> departments, List<Employee> employees)
        {
            string bestDepartment = string.Empty;
            double bestSalary = double.MinValue;

            foreach (var department in departments)
            {
                double average = employees
                    .Where(x => x.Department == department)
                    .Select(s => s.Salary)
                    .Average();

                if (average > bestSalary)
                {
                    bestSalary = average;
                    bestDepartment = department;
                }

            }

            return bestDepartment;
        }
    }
}
