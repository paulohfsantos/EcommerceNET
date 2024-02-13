using EcommerceNet.Domain.Entities;

namespace EcommerceNet.Domain.Interfaces
{
    public interface IProductRepository
    {
        Product GetProductById(int id);
        Product GetProductByName(string name);
        Task<IEnumerable<Product>> GetProductsByCategory(int categoryId); // should be here or in ICategoryRepository?
        Task<Product> CreateProduct(Product product);
        Task<Product> UpdateProduct(Product product);
        Task<Product> DeleteProduct(int productId);
    }
}
