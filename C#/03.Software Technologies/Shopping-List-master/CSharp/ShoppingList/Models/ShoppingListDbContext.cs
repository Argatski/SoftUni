namespace ShoppingList.Controllers
{
    using Microsoft.EntityFrameworkCore;
    using Models;

    public class ShoppingListDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ShoppingListDbContext()
        {
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=CSharp_ShoppingList;user=root;");
        }
    }
}
