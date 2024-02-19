using System.ComponentModel.DataAnnotations;

namespace EcommerceNet.Application.DTOs.ProductDTO
{
    public class AddProductDTO
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int CategoryId { get; set; } // cant have more than one category
    }
}
