using KirdevServer.Domain.Helpers;
using KirdevServer.Services.Dtos.User;

namespace KirdevServer.Services.Database.Interfaces
{
    public interface IUserService 
    {
        Task AddAsync(UserAddDto user, Roles role);
        Task UpdateAsync(UserUpdateDto user, Roles role);
        Task DeleteAsync(Guid id, Roles role);
        Task<UserDto> GetByIdAsync(Guid id, Roles role);
        Task<IEnumerable<UserDto>> GetAllAsync(Roles role);
    }
}
