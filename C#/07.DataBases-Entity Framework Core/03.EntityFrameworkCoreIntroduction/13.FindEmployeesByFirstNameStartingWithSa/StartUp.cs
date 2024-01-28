namespace SoftUni
{
    using SoftUni.Data;
    using System;
    using System.Globalization;
    using System.Text;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            using (SoftUniContext context =  new SoftUniContext())
            {
                string result = GetEmployeesByFirstNameStartingWithSa(context);

                Console.WriteLine(result);
            }
        }

        public static string GetEmployeesByFirstNameStartingWithSa(SoftUniContext context)
        {
            var employess = context.Employees
                .Where(emp => emp.FirstName.StartsWith("Sa"))
                .Select(emp => new { emp.FirstName, emp.LastName, emp.JobTitle, emp.Salary })
                .OrderBy(emp => emp.FirstName)
                .ThenBy(emp => emp.LastName);


            

            StringBuilder sb = new StringBuilder();

            foreach (var e in employess)
            {
                sb.AppendLine($"{e.FirstName} {e.LastName} - {e.JobTitle} - (${e.Salary:f2})");
            }

            return sb.ToString().TrimEnd();
        }
    }
}