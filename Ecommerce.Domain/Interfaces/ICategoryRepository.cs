using EcommerceNet.Domain.Entities;

namespace EcommerceNet.Domain.Interfaces
{
    public interface ICategoryRepository
    {
        Category GetCategoryById(int id);
        Category GetCategoryByName(string name);
        Task<IEnumerable<Category>> GetCategories();
        Task<Category> CreateCategory(Category category);
        Task<Category> UpdateCategory(Category category);
        Task<Category> DeleteCategory(int categoryId); // instead of deleting all products, we just remove category from products
    }
}