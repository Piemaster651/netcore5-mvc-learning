using Database_Connection_Demo.Models;
using Microsoft.EntityFrameworkCore;

namespace Database_Connection_Demo.DataAccess
{
    // EF Context
    public class WebDataContextDB : DbContext
    {
        // These represent tables within the database.
        public DbSet<Product> Product { get; set; }

        public DbSet<Customer> Customer { get; set; }

        // Dependency Injection
        public WebDataContextDB()
        {
        }

        public WebDataContextDB(DbContextOptions<WebDataContextDB> options) 
            : base(options)
        {
            // If there is no database, then create one, if there are no tables, then create them.
            //Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new { ProductID = 1, Name = "Widget" , Qty = 5356, Price = 39.99m, Status = "Active", CreatedDate = System.DateTime.Now }
            );
        }
    }
}