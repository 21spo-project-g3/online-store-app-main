using System.ComponentModel.DataAnnotations;

namespace online_store_app.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public long EAN { get; set; } = 0;
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Description { get; set; } = string.Empty;
        [Required]
        public double Price { get; set; } = 0.00;
        public string ImageUrl { get; set; } = string.Empty;
    }
}
