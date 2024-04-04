
using TestApplication.Models;

namespace TestApplication.Services

{
    public class WarehouseService : IWarehouseService
    {
        public List<WarehouseModel> GetWarehouses()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var warehouses = db.Warehouses.ToList();
                return warehouses;
            }
        }
    }
}
