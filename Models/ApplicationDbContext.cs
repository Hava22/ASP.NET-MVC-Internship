using System.Data.Entity;

namespace ASPNET_MVC_Internship.Models
{
    public class ApplicationDbContext : DbContext
    {
        // For Code First, the database will be created based on models
        // For Database First, you can update this class via EF designer or scaffolding
        public ApplicationDbContext() : base("DefaultConnection")
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
