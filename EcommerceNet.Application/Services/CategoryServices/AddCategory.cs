using EcommerceNet.Application.DTOs.CategoryDTO;
using EcommerceNet.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EcommerceNet.Application.Services.CategoryServices
{
    public class AddCategory
    {
        private readonly DbContext _context;

        public AddCategory(DbContext context)
        {
            _context = context;
        }

        public async Task<Category> AddNewCategory(AddCategoryDTO category)
        {
            var newCategory = new Category
            {
                Name = category.Name,
                Description = category.Description
            };

            await _context.AddAsync(category);
            await _context.SaveChangesAsync();

            return newCategory;
        }
    }
}
