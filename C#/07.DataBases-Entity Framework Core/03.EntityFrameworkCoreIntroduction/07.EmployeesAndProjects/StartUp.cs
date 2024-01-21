namespace SoftUni
{
    using System;
    using System.Linq;
    using System.Text;

    using SoftUni.Data;

    public class StartUp
    {
        public static void Main()
        {
            SoftUniContext context = new SoftUniContext();

            using (context)
            {
                var result = GetEmployeesInPeriod(context);

                Console.WriteLine(result);
            }
        }

        public static string GetEmployeesInPeriod(SoftUniContext context)
        {
            var employees = context.Employees
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    ManagerFirstName = e.Manager.FirstName,
                    ManagerLastName = e.Manager.LastName,
                    Projects = e.Projects.Select(ep => new
                    {
                        ProjectName = ep.Name,
                        ProjectStartDate = ep.StartDate,
                        ProjectEndDate = ep.EndDate
                    })
                })
                .Take(10);

            StringBuilder employeeManagerResult = new StringBuilder();

            foreach (var employee in employees)
            {
                employeeManagerResult.AppendLine($"{employee.FirstName} {employee.LastName} - Manager: {employee.ManagerFirstName} {employee.ManagerLastName}");

                foreach (var project in employee.Projects.Where(p => p.ProjectStartDate.Year >= 2001 && p.ProjectStartDate.Year <= 2003))
                {
                    var startDate = project.ProjectStartDate.ToString("M/d/yyyy h:mm:ss tt");
                    var endDate = project.ProjectEndDate.HasValue ? project.ProjectEndDate.Value.ToString("M/d/yyyy h:mm:ss tt") : "not finished";

                    employeeManagerResult.AppendLine($"--{project.ProjectName} - {startDate}- {endDate}");
                }
            }
            return employeeManagerResult.ToString().TrimEnd();
        }
    }
}