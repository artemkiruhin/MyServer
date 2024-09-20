namespace KirdevServer.Services.Dtos.User
{
    public class UserDto
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public DateOnly Birthday { get; set; } = DateOnly.MinValue;
        public DateTime Registrered { get; set; } = DateTime.Now;
        public string Role {  get; set; } = string.Empty;
    }
}
