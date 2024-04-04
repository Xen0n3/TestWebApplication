using TestApplication.Models;

namespace TestApplication.Services
{
    public interface IWarehouseService
    {
        public List<WarehouseModel> GetWarehouses();
    }
}
