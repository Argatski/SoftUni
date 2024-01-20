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
            using (var context = new SoftUniContext())
            {
                var employeesFullInfo = GetEmployeesWithSalaryOver50000(context);

                Console.WriteLine(employeesFullInfo);
            }
        }

        public static string GetEmployeesWithSalaryOver50000(SoftUniContext context)
        {
            var result = new StringBuilder();

            var employees = context.Employees
                .Select(e => new
                {
                    e.FirstName,
                    e.Salary
                }).Where(e=>e.Salary>50000)
                .OrderBy(e => e.FirstName)
                .ToList();

            foreach (var employee in employees)
            {
                result.AppendLine($"{employee.FirstName} - {employee.Salary:F2}");
            }

            return result.ToString().TrimEnd();
        }
    }
}