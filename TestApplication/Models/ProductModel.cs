using System.ComponentModel.DataAnnotations.Schema;

namespace TestApplication.Models
{
	public class ProductModel
	{
		public int? Id { get; set; }
		public string? Name { get; set; }
		public string? Type { get; set; }
		public string? Color { get; set; }
		public string? ProductionDate { get; set; }
		[NotMapped]
		public DateTime? ProductionDateTime
		{
			get
			{
				if (ProductionDate == null || !DateTime.TryParse(ProductionDate, out DateTime productionDateTime))
				{
					return null;
				}
				return productionDateTime;
			}
		}
		public string? ProducerName { get; set; }
		public string? CountryOfProduction { get; set; }
		public int? Count { get; set; }
		public int? Warehouse {  get; set; } 
	}
}
