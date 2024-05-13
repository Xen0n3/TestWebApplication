using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestApplication.Models
{
    public  class WarehouseModel
    {
        [Key]
        public  int? Id { get; set; }
		public  string?  Name { get; set; }
        public string? Address { get; set; }
        public int? Capacity { get; set; }
        public DateTime? OpenDate { get; set; }
        public string? IsWorking { get; set; }

    }
}
