using Microsoft.AspNetCore.Mvc;
using online_store_app.Data;
using online_store_app.Models;

namespace online_store_app.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ProductController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Product> objProductList = _db.Products.ToList();
            return View(objProductList);
        }
    }
}
