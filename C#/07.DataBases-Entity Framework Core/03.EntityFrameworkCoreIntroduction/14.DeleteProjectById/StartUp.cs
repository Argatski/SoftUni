namespace SoftUni
{
    using SoftUni.Data;
    using SoftUni.Models;
    using System;
    using System.Globalization;
    using System.Text;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            using (SoftUniContext context = new SoftUniContext())
            {
                var result = DeleteProjectById(context);

                Console.WriteLine(result);
            }
        }

        public static string DeleteProjectById(SoftUniContext context)
        {
            var projectToRemove = context.Projects
                .FirstOrDefault(p => p.ProjectId == 2);

            var employeesProjects = context.Employees
                .Where(p => p.ProjectId == 2)
                .ToList();

            foreach (var employeeProject in employeesProjects)
            {
                context.EmployeesProjects.Remove(employeeProject);
            }

            context.Projects.Remove(projectToRemove);

            context.SaveChanges();

            var projects = context.Projects
                .Select(p => p.Name)
                .Take(10)
                .ToList();

            var result = new StringBuilder();

            foreach (var name in projects)
            {
                result.AppendLine(name);
            }

            return result.ToString().TrimEnd();
        }
    }
}