using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniORM.App.Data
{
    using Entities;
    internal class SoftUniDbContextClass:DbContext
    {
        public SoftUniDbContextClass(string connectionString):base(connectionString) { }
        
        public DbSet<Employee> Employees { get; }

        public DbSet<Departments> Departments { get; }

        public DbSet<Project> Projects { get; }

        public DbSet<EmployeesProject> EmployeesProjects { get; }
    }
}
