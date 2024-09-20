using KirdevServer.Domain.Models;
using KirdevServer.Infrastructure.Repositories.Base;

namespace KirdevServer.Infrastructure.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User> GetByUsernameAndPasswordAsync (string username, string password);
    }
}
