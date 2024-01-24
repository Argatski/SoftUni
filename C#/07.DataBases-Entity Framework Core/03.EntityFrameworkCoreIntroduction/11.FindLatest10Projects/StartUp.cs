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
                string result = GetLatestProjects(context);
                Console.WriteLine(result);
            }
           
        }

        public static string GetLatestProjects(SoftUniContext context)
        {
            var projects =  context.Projects
                .OrderByDescending(p=>p.StartDate)
                .Select(p=> new { p.Name,p.Description,p.StartDate })
                .Take(10)
                .OrderBy(p=>p.Name)
                .ToList();

            var stb = new StringBuilder();

            foreach (var project in projects) 
            {
                stb.AppendLine(project.Name);
                stb.AppendLine(project.Description);
                stb.AppendLine(project.StartDate.ToString("M/d/yyyy h:mm:ss tt",CultureInfo.InvariantCulture));
            }

            return stb.ToString().TrimEnd();
        }
    }
}