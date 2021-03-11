using System;
using System.Collections.Generic;
using System.Text;

namespace _01.CompanyRoster
{
    class Department
    {
        public string DepartmentName { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public decimal TotalSalaries { get; set; }

        public void AddNewEmployee(string empName, decimal empSalary)
        {
            TotalSalaries += empSalary;
            Employees.Add(new Employee(empName, empSalary));
        }
        public Department(string departmentName)
        {
            DepartmentName = departmentName;
        }
    }
}
