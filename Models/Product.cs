//Models/Product.cs
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace online_store_app.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string EAN { get; set; } = string.Empty;

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        [Required]
        public double Price { get; set; } = 0.00;

        public string ImageUrl { get; set; } = string.Empty;
        
        [Required]
        public int Quantity { get; set; }

        public bool IsOnSale { get; set; }
        public decimal SalePercentage { get; set; }

        public double AdjustedPrice => IsOnSale ? Price - (Price * (double)SalePercentage / 100) : Price;

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        public double? AverageRating { get; set; }

        public List<ProductReview> Reviews { get; set; } = new List<ProductReview>();
    }
}
