namespace SoftUni
{
    using SoftUni.Data;
    using System;
    using System.Globalization;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            using (SoftUniContext context = new SoftUniContext())
            {
                string result = IncreaseSalaries(context);

                Console.WriteLine(result);
            }

        }

        public static string IncreaseSalaries(SoftUniContext context)
        {
            var deparments = context.Employees.Where(d => d.Department.Name == "Engineering" || d.Department.Name == "Tool Design"
                    || d.Department.Name == "Marketing"
                    || d.Department.Name == "Information Services").ToList();

            foreach (var d in deparments)
            {
                d.Salary += d.Salary * 0.12m;
            }


            context.SaveChanges();


            var updatedEmployyes = context.Employees
                .Where(d => d.Department.Name == "Engineering" || d.Department.Name == "Tool Design"
                    || d.Department.Name == "Marketing"
                    || d.Department.Name == "Information Services")
                .Select(s => new { s.FirstName, s.LastName, s.Salary })
                .OrderBy(s => s.FirstName)
                .ThenBy(s => s.LastName).ToList();

            StringBuilder stb = new StringBuilder();

            foreach (var emp in updatedEmployyes)
            {
                stb.AppendLine($"{emp.FirstName} {emp.LastName} (${emp.Salary:f2})");
            }

            return stb.ToString().TrimEnd();
        }
    }
}