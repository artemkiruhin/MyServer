using KirdevServer.Domain.Models;

namespace KirdevServer.Services.Database.Interfaces
{
    public class UserService : IUserService
    {
        public Task AddAsync(User entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(User entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<User?> GetByUsernameAndPasswordAsync(string username, string passwordHash)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
