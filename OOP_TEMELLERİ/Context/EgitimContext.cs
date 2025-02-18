using Microsoft.EntityFrameworkCore;
using OOP_TEMELLERİ.Entity;

namespace OOP_TEMELLERİ.Context
{
    public class EgitimContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=RecepsLenovo;database=DbNewOopCore;integrated security=true;TrustServerCertificate=True;");

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
