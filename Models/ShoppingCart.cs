using online_store_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace online_store_app.Models
{
	public class ShoppingCart
	{ 
	 private List<CartItem> items = new List<CartItem>();

	public void AddItem(Product product, int quantity)
	{
		CartItem existingItem = items.FirstOrDefault(item => item.Product.Id == product.Id);

		if (existingItem != null)
		{
			existingItem.Quantity += quantity;
		}
		else
		{
			items.Add(new CartItem { Product = product, Quantity = quantity });
		}
	}

	public void RemoveItem(Product product, int quantity)
	{
		CartItem existingItem = items.FirstOrDefault(item => item.Product.Id == product.Id);

		if (existingItem != null)
		{
			if (existingItem.Quantity > quantity)
			{
				existingItem.Quantity -= quantity;
			}
			else
			{
				items.Remove(existingItem);
			}
		}
	}

	public void ClearCart()
	{
		items.Clear();
	}

	public decimal CalculateTotal()
	{
		return (decimal)items.Sum(item => item.Product.AdjustedPrice * item.Quantity);
	}

	public void DisplayCart()
	{
		Console.WriteLine("Shopping Cart Contents:");
		foreach (var item in items)
		{
			Console.WriteLine($"{item.Product.Name} - Quantity: {item.Quantity} - Price: {item.Product.AdjustedPrice:C}");
		}

		Console.WriteLine($"Total: {CalculateTotal():C}");
	}
}

public class CartItem
{
	public Product Product { get; set; }
	public int Quantity { get; set; }
}


	}
