using System.Collections.Generic;
using System.Linq;

namespace ProfiseeDemo.Models;

public class Cart
{
	public List<CartRec> Lines { get; set; } = new List<CartRec>();

	public virtual void AddItem(Product product, int quantity)
	{
		CartRec? line = Lines.FirstOrDefault(p => p.Product.ProductID == product.ProductID);

		if (line == null)
		{
			Lines.Add(new CartRec
			{
				Product = product,
				Quantity = quantity
			});
		}
		else
			line.Quantity += quantity;
	}

	public void RemoveLine(Product product) => Lines.RemoveAll(l => l.Product.ProductID == product.ProductID);

	public decimal ComputeTotalValue() => Lines.Sum(e => e.Product.Price * e.Quantity);

	public void Clear() => Lines.Clear();
}

public class CartRec
{
	public int CartRecID { get; set; }
	public Product? Product { get; set; }
	public int Quantity { get; set; }
}