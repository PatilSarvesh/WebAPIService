using Microsoft.EntityFrameworkCore;
using ProductsCatalogService.Model.Entities;

namespace ProductsCatalogService.Model.Data
{
    public class ProductsCatalogDbContext:DbContext

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=ProductsCatalogDb;Integrated Security=True");
        }
        
        public DbSet<Product> Products { get; set; }
    }
}
