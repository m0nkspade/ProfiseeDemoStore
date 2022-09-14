using Microsoft.EntityFrameworkCore;
using ProfiseeDemo.Models;
using System.Collections.Generic;

namespace ProfiseeDemo.Models
{
	public class StoreDbContext : DbContext
	{

		public StoreDbContext(DbContextOptions<StoreDbContext> options)
			 : base(options) { }

		public DbSet<Product> Products { get; set; }
		//public DbSet<Order> Orders { get; set; }
	}
}