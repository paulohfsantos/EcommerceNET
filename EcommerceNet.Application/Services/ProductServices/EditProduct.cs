using EcommerceNet.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EcommerceNet.Application.Services.ProductServices
{
    public class EditProduct
    {
        private readonly DbContext _context;

        public EditProduct(DbContext context)
        {
            _context = context;
        }

        public async Task<Product> EditCurrentProduct(Product product)
        {
            var productToEdit = await _context.FindAsync<Product>(product.Id)
                ?? throw new Exception("Product not found");

            productToEdit.Name = product.Name;
            productToEdit.Description = product.Description;
            productToEdit.Price = product.Price;
            productToEdit.CategoryId = product.CategoryId;

            await _context.SaveChangesAsync();
            await _context.Entry(productToEdit).ReloadAsync();

            return productToEdit;
        }
    }
}
