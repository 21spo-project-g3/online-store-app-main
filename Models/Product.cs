using System.ComponentModel.DataAnnotations;

namespace online_store_app.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int SerialNumber { get; set; }
        [Required]
        public string Name { get; set; } = "Null";
        [Required]
        public string Category { get; set; } = "Null";
        [Required]
        public string Description { get; set; } = "";
        [Required]
        public decimal Price { get; set; } = 0;
        [Required]
        public string PriceUnit { get; set; } = "€";
        public string ImageId { get; set; } = "";

    }
}
