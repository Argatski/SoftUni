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

/*Another Solution
//Input lines 
            int number = int.Parse(Console.ReadLine());

            List<EmployeeHelper> employees = new List<EmployeeHelper>();

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
                    EmployeeHelper employee = new EmployeeHelper(name, salary, namePosition, department, @"n/a", -1);

                    employees.Add(employee);
                }
                if (argummets.Length == 5)
                {
                    string currentValue = argummets[4];
                    int age;

                    bool success = int.TryParse(currentValue, out age);

                    if (success)
                    {
                        EmployeeHelper employee = new EmployeeHelper(name, salary, namePosition, department, @"n/a", age);
                        employees.Add(employee);
                    }
                    else
                    {
                        EmployeeHelper employee = new EmployeeHelper(name, salary, namePosition, department, currentValue, -1);
                        employees.Add(employee);

                    }
                }
                else if (argummets.Length > 5)
                {
                    string email = argummets[4];
                    int age = int.Parse(argummets[5]);

                    EmployeeHelper employee = new EmployeeHelper(name, salary, namePosition, department, email, age);
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

        private static string GetBestDepartment(HashSet<string> departments, List<EmployeeHelper> employees)
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
 */
