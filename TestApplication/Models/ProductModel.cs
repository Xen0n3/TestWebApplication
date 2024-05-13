using System.ComponentModel.DataAnnotations.Schema;

namespace TestApplication.Models
{
	public class ProductModel
	{
		public int? Id { get; set; }
		public string? Name { get; set; }
		public string? Type { get; set; }
		public string? Color { get; set; }
		public DateTime? ProductionDate { get; set; }
		public string? ProducerName { get; set; }
		public string? CountryOfProduction { get; set; }
		public int? Count { get; set; }
		public int? Warehouse {  get; set; } 
	}
}
