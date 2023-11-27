using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using online_store_app.Data;

namespace online_store_app.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext productService)
        {
            _context = productService;
        }

        public IActionResult Details(string ean)
        {

            var product = _context.Products
                .Include(p => p.Category)
                .FirstOrDefault(p => p.EAN == ean);
            return View(product);
        }
    }
}
