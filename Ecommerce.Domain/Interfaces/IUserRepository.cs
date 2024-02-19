using EcommerceNet.Domain.Entities;

namespace EcommerceNet.Domain.Interfaces
{
    public interface IUserRepository
    {
        User GetProfile(int id);
        Task<User> UpdateUser(User user);
        Task<User> DeactivateUser(int userId); // deactivate user: set IsActive to false
    }
}
