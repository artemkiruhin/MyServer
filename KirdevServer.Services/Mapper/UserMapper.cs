using KirdevServer.Domain.Models;
using KirdevServer.Services.Dtos.User;
using KirdevServer.Services.Mapper.Base;

namespace KirdevServer.Services.Mapper
{
    public class UserMapper : IMapper<User, UserDto>
    {
        public User ToDomain(UserDto dto)
        {
            return User.Create(dto.Id, dto.Username, dto.Email, dto.PasswordHash, dto.Birthday, dto.Registrered);
        }

        public UserDto ToDto(User domain)
        {
            return new UserDto()
            {
                Id = domain.Id,
                Username = domain.Username,
                Email = domain.Email,
                PasswordHash = domain.PasswordHash,
                Birthday = domain.Birthday,
                Registrered = domain.Registred
            };
        }
    }
}
