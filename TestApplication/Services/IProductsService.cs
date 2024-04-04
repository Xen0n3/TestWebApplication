using TestApplication.Models;

namespace TestApplication.Services
{
	public interface IProductsService
	{
		public List<ProductModel> GetProducts();
		public List<ProductModel> GetProductsByWarehouse(int? warehouse);

	}
}
