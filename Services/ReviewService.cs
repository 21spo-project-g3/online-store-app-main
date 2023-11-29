// Services/ReviewService.cs
using online_store_app.Data;
using online_store_app.Models;
using System;

namespace online_store_app.Services
{
    public class ReviewService
    {
        private readonly ApplicationDbContext _context;

        public ReviewService(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool AddReview(ReviewViewModel model, string userId)
        {
            try
            {
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
                return true;
            }
            catch (Exception ex)
            {
                // Log the exception for debugging
                Console.WriteLine($"Error saving review: {ex.Message}");
                return false;
            }
        }
    }
}
