using ECommerce.Models.EntityModels;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Database.DbContexts
{
    // Here DbContext class inherited for getting the feature of the database
    public class SMEDBContext : DbContext
    {
        // For creating dbset or table in the database
        public DbSet<Catagory> Catagories { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Item> Products { get; set; } // We can also script this line .
                                                  // EFCore will automatically create a table named product/item.
                                                  // Using the relationship between Item and Category class

        public SMEDBContext(DbContextOptions options):base(options)
        {

        }

        // it's a predefined method of DbContext class and here we just override it
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            ////for connecting the Database server
            //string connectionString = @"Server=DELL\SQLEXPRESS;Database=UCECommerceDB;Integrated Security=true";
            //optionsBuilder
            //    //.UseLazyLoadingProxies()
            //    .UseSqlServer(connectionString);
        }
    }
}