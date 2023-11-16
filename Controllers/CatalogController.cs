using Microsoft.AspNetCore.Mvc;

namespace online_store_app.Controllers
{
    public class CatalogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
