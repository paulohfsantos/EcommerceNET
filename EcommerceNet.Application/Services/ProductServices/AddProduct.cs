using EcommerceNet.Application.DTOs.ProductDTO;
using EcommerceNet.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EcommerceNet.Application.Services.ProductServices
{
    public class AddProduct
    {
        private readonly DbContext _context;

        public AddProduct(DbContext context)
        {
            _context = context;
        }

        public async Task<Product> AddNewProduct(AddProductDTO product)
        {
            var newProduct = new Product
            {
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                CategoryId = product.CategoryId,
            };

            await _context.AddAsync(product);
            await _context.SaveChangesAsync();

            return newProduct;
        }
    }
}
