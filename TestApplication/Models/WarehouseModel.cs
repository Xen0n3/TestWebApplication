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
        public string? OpenDate { get; set; }

        [NotMapped]
        public DateTime? OpenDateTime 
        {
            get
            {
                if (OpenDate == null || !DateTime.TryParse(OpenDate,out DateTime openDateTime)) 
                {
                    return null;
                }
                return openDateTime;
            } 
        }
        public string? IsWorking { get; set; }

    }
}
