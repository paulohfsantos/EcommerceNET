using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceNet.Domain.Entities
{
    public class Product
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        public decimal Price { get; set; } = 0;

        public decimal PriceCeiling { get; set; } = 0;

        public decimal PriceFloor { get; set; } = 0;

        [Required]
        public int StockQuantity { get; set; }

        [Required]
        public Category Category { get; set; } // handle this later

        [Required]
        public int CategoryId { get; set; }
    }
}