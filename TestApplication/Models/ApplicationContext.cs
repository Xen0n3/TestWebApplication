using Microsoft.EntityFrameworkCore;
namespace TestApplication.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<WarehouseModel> Warehouses => Set<WarehouseModel>();
		public DbSet<ProductModel> Products => Set<ProductModel>();

       public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        { 

        }
    }
}
