using Matchly.Entities;

namespace Matchly.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
