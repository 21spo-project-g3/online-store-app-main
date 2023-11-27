using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using online_store_app.Data;
using online_store_app.Models;
using System.Linq;

namespace online_store_app.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Details(string ean)
        {
            var product = _context.Products
                .Include(p => p.Category)
                .FirstOrDefault(p => p.EAN == ean);

            if (product == null)
            {
                return NotFound();
            }

            var reviews = _context.ProductReviews
                .Where(r => r.ProductId == product.Id)
                .ToList();

            // You can now access the reviews in your product details view

            return View(product);
        }

        // Add other actions as needed
    }
}
