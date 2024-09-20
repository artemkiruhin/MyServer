using KirdevServer.Domain.Models;
using KirdevServer.Services.Dtos.User;
using KirdevServer.Services.Mapper.Base;

namespace KirdevServer.Services.Mapper
{
    public class UserMapper : IMapper<User, UserDto>
    {
        public User ToDomain(UserDto dto)
        {
            throw new NotImplementedException();
        }

        public UserDto ToDto(User domain)
        {
            throw new NotImplementedException();
        }
    }
}
