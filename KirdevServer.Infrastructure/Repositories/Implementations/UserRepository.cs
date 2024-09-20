using KirdevServer.Domain.Models;
using KirdevServer.Infrastructure.Database;
using KirdevServer.Infrastructure.Repositories.Base;
using KirdevServer.Infrastructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace KirdevServer.Infrastructure.Repositories.Implementations
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context) : base(context) 
        {
            _context = context;
        }

        public async Task<User?> GetByUsernameAndPasswordAsync(string username, string passwordHash)
        {
            return await _context.Users.FirstOrDefaultAsync(e => e.Username.Equals(username) && e.PasswordHash.Equals(passwordHash));
        }
    }
}
