using System.ComponentModel.DataAnnotations;

namespace EcommerceNet.Application.DTOs.CategoryDTO
{
    public class AddCategoryDTO
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int CategoryId { get; set; }
    }
}
