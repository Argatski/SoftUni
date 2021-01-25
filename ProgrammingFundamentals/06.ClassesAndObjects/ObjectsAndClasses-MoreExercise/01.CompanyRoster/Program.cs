using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CompanyRoster
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            List<Department> departments = new List<Department>();

            //Solution
            InputNameOfList(departments);

            ChekHighestAverage(departments);
        }

        static void ChekHighestAverage(List<Department> dep)
        {
            Department bestDepartment = dep.OrderByDescending(d => d.TotalSalaries / d.Employees.Count()).First();
            Console.WriteLine($"Highest Average Salary: {bestDepartment.DepartmentName}");

            foreach (var emp in bestDepartment.Employees.OrderByDescending(e=>e.Salary))
            {
                Console.WriteLine($"{emp.Name} {emp.Salary:f2}");
            }

        }

        static void InputNameOfList(List<Department> dep)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] array = Console.ReadLine().Split(" ");

                string name = array[0];
                decimal price = decimal.Parse(array[1]);
                string department = array[2];

                if (!dep.Any(d => d.DepartmentName == department))
                {
                    dep.Add(new Department(department));
                }

                dep.Find(d => d.DepartmentName == department).AddNewEmployee(name, price);
            }
        }
    }

    //class Department
    //{
    //    public string DepartmentName { get; set; }
    //    public List<Employee> Employees { get; set; } = new List<Employee>();
    //    public decimal TotalSalaries { get; set; }

    //    public void AddNewEmployee(string empName, decimal empSalary)
    //    {
    //        TotalSalaries += empSalary;
    //        Employees.Add(new Employee(empName, empSalary));
    //    }
    //    public Department(string departmentName)
    //    {
    //        DepartmentName = departmentName;
    //    }
    //}
    //class Employee
    //{
    //    public string Name { get; set; }
    //    public decimal Salary { get; set; }

    //    public Employee(string name, decimal salary)
    //    {
    //        Name = name;
    //        Salary = salary;
    //    }
    //}
}
