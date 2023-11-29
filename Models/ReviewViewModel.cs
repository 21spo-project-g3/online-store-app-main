// Models/ReviewViewModel.cs
using System.ComponentModel.DataAnnotations;

namespace online_store_app.Models
{
    public class ReviewViewModel
    {
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        [MaxLength(255, ErrorMessage = "Title cannot exceed 255 characters.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Content is required.")]
        public string Content { get; set; }

        [Required(ErrorMessage = "Rating is required.")]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
        public int Rating { get; set; }
    }
}
