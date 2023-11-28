using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using online_store_app.Data;
using online_store_app.Models;
using System;
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


        [HttpGet]
        public IActionResult Review(int productId)
        {
            var model = new ProductReview { ProductId = productId };
            return View(model);
        }

        [HttpPost]
        public IActionResult Review(ProductReview model)
        {
            if (ModelState.IsValid)
            {
                // Assuming you are using Azure SQL Authentication, replace this with your logic to get the current user ID
                var userId = "<Your logic to get user ID>";

                var review = new ProductReview
                {
                    ProductId = model.ProductId,
                    Title = model.Title,
                    Content = model.Content,
                    Rating = model.Rating,
                    UserId = userId,
                    CreatedAt = DateTime.Now
                };

                _context.ProductReviews.Add(review);
                _context.SaveChanges();

                // Redirect to the main menu after submitting the review
                return RedirectToAction("Index", "Home");
            }

            // If there are validation errors, return to the review form with the model
            return View(model);
        }


        // Add other actions as needed
    }
}
