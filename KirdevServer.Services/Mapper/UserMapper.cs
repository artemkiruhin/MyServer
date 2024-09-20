using KirdevServer.Domain.Models;
using KirdevServer.Services.Dtos.User;
using KirdevServer.Services.Mapper.Base;

namespace KirdevServer.Services.Mapper
{
    public class UserMapper : IMapper<User, UserDto>
    {
        public User ToDomain(UserDto dto)
        {
            User.Create(dto.Id, dto.Username, dto.PasswordHash, dto.Birthday, dto.Registrered);
        }

        public UserDto ToDto(User domain)
        {
            throw new NotImplementedException();
        }
    }
}
