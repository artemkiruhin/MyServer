using KirdevServer.Domain.Helpers;
using KirdevServer.Services.Database.Interfaces;
using KirdevServer.Services.Dtos.User;

namespace KirdevServer.Services.Database
{
    public class UserService : IUserService
    {
        public Task AddAsync(UserAddDto user, Roles role)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id, Roles role)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserDto>> GetAllAsync(Roles role)
        {
            throw new NotImplementedException();
        }

        public Task<UserDto> GetByIdAsync(Guid id, Roles role)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(UserUpdateDto user, Roles role)
        {
            throw new NotImplementedException();
        }
    }
}
