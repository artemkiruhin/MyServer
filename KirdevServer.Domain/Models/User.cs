using KirdevServer.Domain.Helpers;

namespace KirdevServer.Domain.Models
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public DateOnly Birthday { get; set; } = DateOnly.MinValue;
        public DateTime Registred { get; set; } = DateTime.Now;
        public Roles Role { get; set; } = Roles.USER;

        private User(Guid id, string username, string email, string passwordHash, DateOnly birthday, DateTime registered, Roles role)
        {
            Id = id;
            Username = username;
            Email = email;
            PasswordHash = passwordHash;
            Birthday = birthday;
            Registred = registered;
            Role = role;
        }

        public static User Create(Guid id, string username, string email, string passwordHash, DateOnly birthday, DateTime registered, Roles role)
        {
            return new User(id, username, email, passwordHash, birthday, registered, role);
        }
    }
}
