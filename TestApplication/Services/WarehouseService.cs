
using Microsoft.EntityFrameworkCore;
using TestApplication.Models;

namespace TestApplication.Services

{
    public class WarehouseService : IWarehouseService
    {
        public WarehouseService(ApplicationContext context)
        {
            _context = context;
        }
        private readonly ApplicationContext _context;
        public List<WarehouseModel> GetWarehouses()
        {     
                var warehouses = _context.Warehouses.ToList();
                return warehouses; 
        }
    }
}
