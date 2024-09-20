namespace KirdevServer.Services.Mapper.Base
{
    public interface IMapper<TDomain, TDto>
    {
        TDomain ToDomain (TDto dto);
        TDto ToDto (TDomain domain);
    }
}
