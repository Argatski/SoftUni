﻿using MiniORM.App.Data;
using MiniORM.App.Data.Entities;

internal class StartUp
{
    private static void Main(string[] args)
    {
        var connectionString = "Server=DESKTOP-P22IBOP\\MSSQLSERVER_2023;Database=MiniORM;Integrated Security=True;TrustServerCertificate=True";

        var context =  new SoftUniDbContextClass(connectionString);

        context.Employees.Add(new Employee
        {
            FirstName = "Gosho",
            LastName = "Inserted",
            DepartmentId = context.Departments.First().Id,
            IsEmployed = true

        });

        var employee = context.Employees.Last();
        employee.FirstName = "Modified";

        context.SaveChanges();
            
         
    }
}