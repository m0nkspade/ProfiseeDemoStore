using System.ComponentModel.DataAnnotations.Schema;

namespace ProfiseeDemo.Models
{

	/// <summary>
	/// This is the product the store will be selling to customers
	/// </summary>
	public class Product
	{

		public long ProductID { get; set; }

		public string Name { get; set; }

		public string Description { get; set; }

		[Column(TypeName = "decimal(8, 2)")]
		public decimal Price { get; set; }

		public string Category { get; set; }
	}
}