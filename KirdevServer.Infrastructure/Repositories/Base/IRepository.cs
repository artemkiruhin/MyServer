namespace KirdevServer.Infrastructure.Repositories.Base
{
    public interface IRepository <T> where T : class
    {
        Task<bool> Add(T entity);
        Task<bool> Update(T entity);
        Task<bool> Delete(T entity);
        Task<T> GetById(Guid id);
        Task<IEnumerable<T>> GetAll();
    }
}
