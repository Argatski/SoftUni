using SoftUni.Data;
using SoftUni.Models;
using System.Text;

namespace SoftUni
{

    public class StartUp
    {
        public static void Main()
        {
            using (SoftUniContext context = new SoftUniContext())
            {
                string result = GetEmployeesFromResearchAndDevelopment(context);

                Console.WriteLine(result);
            }

        }

        public static string GetEmployeesFromResearchAndDevelopment(SoftUniContext context)
        {
            var str = new StringBuilder();

            var employees = context.Employees
                .Select(
                e => new 
                { 
                    e.FirstName,
                    e.LastName,
                    DepartmentName = e.Department.Name,
                    e.Salary }
                )
                .Where(e => e.DepartmentName == "Research and Development")
                .OrderBy(e => e.Salary)
                .ThenByDescending(e => e.FirstName)
                .ToList();

            foreach ( var employee in employees )
            {
                str.AppendLine($"{employee.FirstName} {employee.LastName} from {employee.DepartmentName} - {employee.Salary:f2}");
            }

            return str.ToString().TrimEnd();
        }
    }
}