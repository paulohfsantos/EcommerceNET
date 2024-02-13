namespace EcommerceNet.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; } // decimal or bigInt?
        public decimal PriceCeiling { get; set; }
        public decimal PriceFloor { get; set; }
        public int StockQuantity { get; set; }
        public Category Category { get; set; }
    }
}