using Microsoft.AspNetCore.Mvc;

namespace online_store_app.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
