
using TestApplication.Models;

namespace TestApplication.Services

{
	public class ProductsService : IProductsService
	{
		public List<ProductModel> GetProducts()
		{
			using (ApplicationContext db = new ApplicationContext())
			{
				var products = db.Products.ToList();
				return products;
			}
		}
		public List<ProductModel> GetProductsByWarehouse(int? warehouseId) 
		{
            using (ApplicationContext db = new ApplicationContext())
            {
				var warehouseProducts = db.Products.Where(p => p.Warehouse == warehouseId).ToList();
                return warehouseProducts;
            }
            
		}
	}
}
