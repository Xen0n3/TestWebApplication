
using TestApplication.Models;

namespace TestApplication.Services

{
    public class ProductsService : IProductsService
    {
        public ProductsService(ApplicationContext context)
        {
            _context = context;
        }
        private readonly ApplicationContext _context;
        public List<ProductModel> GetProducts()
        {
            var products = _context.Products.ToList();
            return products;
        }
        public List<ProductModel> GetProductsByWarehouse(int? warehouseId)
        {
            var warehouseProducts = _context.Products.Where(p => p.Warehouse == warehouseId).ToList();
            return warehouseProducts;
        }
    }
}
