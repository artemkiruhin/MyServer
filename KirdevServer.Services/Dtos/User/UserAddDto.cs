namespace KirdevServer.Services.Dtos.User
{
    public class UserAddDto
    {
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public DateOnly Birthday { get; set; } = DateOnly.MinValue;
        public DateTime Registrered { get; set; } = DateTime.Now;
    }
}
}
