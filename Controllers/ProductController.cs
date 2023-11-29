// Controllers/ProductController.cs
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using online_store_app.Data;
using online_store_app.Models;
using online_store_app.Services;
using System.Security.Claims;

namespace online_store_app.Controllers
{
    public class ProductController : Controller
    {
        private readonly ReviewService _reviewService;
        private readonly ApplicationDbContext _context;  // Add this line

        public ProductController(ReviewService reviewService, ApplicationDbContext context)
        {
            _reviewService = reviewService;
            _context = context;  // Add this line
        }

        [HttpGet]
        [Authorize]
        public IActionResult Review(int productId)
        {
            var model = new ReviewViewModel { ProductId = productId };
            return View(model);
        }

        [Authorize]
        [HttpPost]
        public IActionResult Review(ReviewViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Get the current user's Id from the HttpContext
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                if (userId != null)
                {
                    var reviewAdded = _reviewService.AddReview(model, userId);

                    if (reviewAdded)
                    {
                        // Redirect to the main menu after successful submission
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        // Handle the case where the review couldn't be added
                        return StatusCode(500, "Internal Server Error");
                    }
                }
                else
                {
                    // Log a warning or handle the case where userId is null
                    Console.WriteLine("User Id is null.");
                    return StatusCode(500, "Internal Server Error");
                }
            }

            // If there are validation errors, return to the review form with the model
            return View(model);
        }

        public IActionResult Details(string ean)
        {
            var product = _context.Products
                .Include(p => p.Category)
                .Include(p => p.Reviews)  // Include reviews here
                .FirstOrDefault(p => p.EAN == ean);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
    }
}
