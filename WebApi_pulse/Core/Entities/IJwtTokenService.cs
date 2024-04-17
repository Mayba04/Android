using Core.Entities.Identity;

namespace Core.Entities
{
    public interface IJwtTokenService
    {
        Task<string> CreateToken(UserEntity user);
    }
}
