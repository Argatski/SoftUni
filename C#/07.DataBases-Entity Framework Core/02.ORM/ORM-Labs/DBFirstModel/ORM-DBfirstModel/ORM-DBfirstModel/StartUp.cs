using ORM_DBfirstModel.Model;
using System.Data.SqlTypes;

internal class StartUp
{
    private static void Main(string[] args)
    {
        var dbContext = new SoftuniContext();
        /*
        var employees =  dbContext.Employees.Where(x => x.Department.Manager.Department.Name == "Sales")
            .Select(x => new
            {
                Name = x.FirstName + ' ' + x.LastName,
                Department =  x.Department.Name,
                Manger =  x.Manager.FirstName+ ' ' + x.Manager.LastName
            });

        foreach (var emp in employees)
        {
            Console.WriteLine(emp.Name+ ' - '+emp.Department + ' - ' + emp.Manger);

        }
        */

        var allEmp = dbContext.Employees.ToList();
       
        foreach (var emp in allEmp) 
        {
            Console.WriteLine(emp.FirstName + ' ' + emp.LastName + " - " + emp.Salary);
        }
    }
}