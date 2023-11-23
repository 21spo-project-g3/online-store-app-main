using Microsoft.AspNetCore.Mvc;
using online_store_app.Data;

namespace online_store_app.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        
        public IActionResult Technology() 
        {
            var technologyProducts = _db.GetProductsByCategory("Technology");
            return View(technologyProducts);
        
        }

        public IActionResult Gaming()
        {
            var gamingProducts = _db.GetProductsByCategory("Gaming");
            return View(gamingProducts);

        }

        public IActionResult Picture_and_sound()
        {
            var pnsProducts = _db.GetProductsByCategory("Picture & sound");
            return View(pnsProducts);

        }

        public IActionResult Phones_and_tablets()
        {
            var pntProducts = _db.GetProductsByCategory("Phones & tablets");
            return View(pntProducts);

        }

        public IActionResult Hobbies_and_free_time()
        {
            var hnftProducts = _db.GetProductsByCategory("Hobbies & free time");
            return View(hnftProducts);
        }
        
    }
}
