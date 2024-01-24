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
                var result = GetDepartmentsWithMoreThan5Employees(context);

                Console.WriteLine(result);
            }
        }

        public static string GetDepartmentsWithMoreThan5Employees(SoftUniContext context)
        {
            

            var departmets = context.Departments
                .Where(d => d.Employees.Count > 5)
                .OrderBy(d => d.Employees.Count)
                .ThenBy(d => d.Name)
                .Select(
                         d =>
                        new
                        {
                            d.Name,
                            ManagerFirstName = d.Manager.FirstName,
                            ManagerLastName = d.Manager.LastName,
                            Employees = d.Employees
                        .Select(e => new
                        {
                            e.FirstName,
                            e.LastName,
                            e.JobTitle
                        })
                        }
                ).ToList();


            StringBuilder stb = new StringBuilder();

            foreach (var dep in departmets)
            {
                stb.AppendLine($"{dep.Name} - {dep.ManagerFirstName} {dep.ManagerLastName}");

                foreach (var item in dep.Employees)
                {
                    stb.AppendLine($"{item.FirstName} {item.LastName} - {item.JobTitle}");
                }
            }

            return stb.ToString().TrimEnd();
        }
    }
}