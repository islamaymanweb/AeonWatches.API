

using AeonWatches.API.Entities.UserEntities;

namespace AeonWatches.API.Services;

public interface ITokenService
{
    string CreateToken(AppUser user);
}