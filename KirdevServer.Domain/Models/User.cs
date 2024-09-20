namespace KirdevServer.Domain.Models
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public DateOnly Birthday { get; set; } = DateOnly.MinValue;
        public DateTime Registrered { get; set; } = DateTime.Now;

        private User(Guid id, string username, string email, string passwordHash, DateOnly birthday)
        {
            Id = id;
            Username = username;
            Email = email;
            PasswordHash = passwordHash;
            Birthday = birthday;
            Registered = DateTime.Now;
        }

        public static User Create(Guid id, string username, string email, string passwordHash, DateOnly birthday)
        {
            return new User(id, username, email, passwordHash, birthday);
        }
    }
}
