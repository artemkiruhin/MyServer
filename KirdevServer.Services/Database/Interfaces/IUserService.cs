using KirdevServer.Services.Database.Base;
using KirdevServer.Services.Dtos.User;

namespace KirdevServer.Services.Database.Interfaces
{
    public interface IUserService
    {
        Task AddAsync(UserAddDto user);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<T> GetByIdAsync(Guid id);
        Task<IEnumerable<T>> GetAllAsync();
    }
}
