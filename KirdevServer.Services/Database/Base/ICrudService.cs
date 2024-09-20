using KirdevServer.Domain.Helpers;

namespace KirdevServer.Services.Database.Base
{
    public interface ICrudService<T> where T : class
    {
        Task AddAsync(T entity, Roles role);
        Task UpdateAsync(T entity, Roles role);
        Task DeleteAsync(T entity, Roles role);
        Task<T> GetByIdAsync(Guid id, Roles role);
        Task<IEnumerable<T>> GetAllAsync(Roles role);
    }
}
