using Microsoft.EntityFrameworkCore;
namespace TestApplication.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<WarehouseModel> Warehouses => Set<WarehouseModel>();
		public DbSet<ProductModel> Products => Set<ProductModel>();
		public ApplicationContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=productsStorage.db");
        }
    }
}
