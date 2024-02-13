using EcommerceNet.Domain.Entities;

namespace EcommerceNet.Domain.Interfaces
{
    public interface IUserRepository
    {
        User GetUserById(int id);
        User GetUserByUsername(string username);
        User GetUserByEmail(string email);
        Task<User> UpdateUser(User user);
        Task<User> DeactivateUser(int userId); // deactivate user: set IsActive to false
    }
}
