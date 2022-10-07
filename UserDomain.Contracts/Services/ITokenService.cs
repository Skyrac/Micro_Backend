using UserDomain.Contracts.Data.Entities;
using UserDomain.Contracts.DTO;

namespace UserDomain.Contracts.Services
{
    public interface ITokenService
    {
        AuthTokenDTO Generate(User user);
    }
}