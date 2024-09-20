using KirdevServer.Domain.Models;
using KirdevServer.Services.Database.Interfaces;
using KirdevServer.Services.Dtos.User;

namespace KirdevServer.Services.Database
{
    public class UserService : IUserService
    {
        public Task AddAsync(UserAddDto user, object )
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(UserUpdateDto user)
        {
            throw new NotImplementedException();
        }
    }
}
