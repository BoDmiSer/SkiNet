using SkiNet.Models.Identity;

namespace SkiNet.Services.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
