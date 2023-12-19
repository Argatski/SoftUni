using ORM_CodeFirst.Models;

internal class StartUp
{
    private static void Main(string[] args)
    {
        var dbContext = new StudentDBContext();

        dbContext.Database.EnsureCreated();
        dbContext.Courses.Add(new Course { Name = "EntityFrameworkCore" });
        dbContext.Courses.Add(new Course { Name = "SqlServer" });
       
        //dbContext.Courses.Remove(new Course { Id = 1 });
        
        dbContext.SaveChanges();
    }
}