// AdminController.cs
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using online_store_app.Data;
using online_store_app.Models;
using System.Collections.Generic;
using System.Linq;

public class AdminController : Controller
{
    private readonly ApplicationDbContext _context;

    public AdminController(ApplicationDbContext context)
    {
        _context = context;
    }

    [Authorize(Policy = "AdminOnly")]
    public IActionResult InventoryManagement()
    {
        var allProducts = _context.Products.ToList(); // Get all products

        // Set ViewData for low quantity products count
        ViewData["LowQuantityProductsCount"] = allProducts.Count(p => p.Quantity < 5);

        return View(allProducts);
    }

    [HttpPost]
    [Authorize(Policy = "AdminOnly")]
    public IActionResult UpdateQuantities(List<int> quantities, List<Product> products)
    {
        for (int i = 0; i < quantities.Count; i++)
        {
            var productId = products[i].Id;
            var newQuantity = quantities[i];

            // Retrieve the product from the database
            var product = _context.Products.Find(productId);

            if (product != null)
            {
                // Update the quantity
                product.Quantity = newQuantity;

                // Update sale information
                product.IsOnSale = products[i]?.IsOnSale ?? false; // Default to false if IsOnSale is null
                product.SalePercentage = products[i]?.SalePercentage ?? 0; // Default to 0 if SalePercentage is null
            }
        }

        // Save changes to the database
        _context.SaveChanges();

        // Redirect back to the InventoryManagement action
        return RedirectToAction(nameof(InventoryManagement));
    }
}
