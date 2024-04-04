using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TestApplication.Models;
using TestApplication.Services;

namespace TestApplication.Controllers
{

    public class HomeController : Controller
    {
		public string About() => "About Page";
		private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
       
        public IActionResult Warehouses()
        {
           var warehouseService = HttpContext.RequestServices.GetService<IWarehouseService>();
            var warehouses = warehouseService?.GetWarehouses();

            return View(warehouses);
        }
        public IActionResult WarehouseProducts(WarehouseModel warehouse)
        {
            var productsService = HttpContext.RequestServices.GetService<IProductsService>();
            var warehouseProducts = productsService?.GetProductsByWarehouse(warehouse.Id);
            return View(warehouseProducts);
        }
        public IActionResult Products()
        {
			var productsService = HttpContext.RequestServices.GetService<IProductsService>();
			var products = productsService?.GetProducts();
			return View(products);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });

        } 


	}
}
