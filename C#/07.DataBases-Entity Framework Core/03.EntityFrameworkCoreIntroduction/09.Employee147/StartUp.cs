namespace SoftUni
{
    using SoftUni.Data;
    using System;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            using (SoftUniContext context = new SoftUniContext())
            {
                var result = GetEmployee147(context);

                Console.WriteLine(result);
            }
        }

        public static string GetEmployee147(SoftUniContext context)
        {

            var employee = context.Employees
                            .Where(e => e.EmployeeId == 147)
                            .Select(e => new
                            {
                                e.FirstName,
                                e.LastName,
                                e.JobTitle,
                                e.Projects
                                    
                            })
                            .FirstOrDefault();

           

            StringBuilder sb = new StringBuilder();

           sb.AppendLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle}");
            foreach (var project in employee.Projects.OrderBy(p=>p.Name))
            {
                sb.AppendLine(project.Name);
            }


            return sb.ToString().TrimEnd();
        }
    }
}