using Microsoft.EntityFrameworkCore;
using NTier.Entities;

namespace NTier.DataAccess.Concrete
{
    public class NTier_Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-NK59MDB;Database=ConsoleAppDB;Trusted_Connection=true");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
    }
}
