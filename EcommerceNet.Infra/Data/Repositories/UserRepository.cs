using EcommerceNet.Domain.Entities;
using EcommerceNet.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EcommerceNet.Infra.Data.DatabaseContext
{
    public class UserRepository: IUserRepository
    {
        private readonly DbContext _context;

        public UserRepository(DbContext context)
        {
            _context = context;
        }

        public async User GetProfile(int id)
        {
            return _context.Find<User>(id) ?? throw new Exception("User not found");
        }

        public Task<User> UpdateUser(User user)
        {
            var userToUpdate = _context.Find<User>(user.Id) ?? throw new Exception("User not found");
            userToUpdate.Firstname = user.Firstname;
            userToUpdate.Lastname = user.Lastname;

            return userToUpdate;

        }

        public Task<User> DeactivateUser(int userId)
        {
        }
    }
}
