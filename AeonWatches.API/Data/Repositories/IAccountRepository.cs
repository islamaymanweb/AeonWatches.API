

using AeonWatches.API.DTOs.UserDTOs;
using AeonWatches.API.Entities.UserEntities;

namespace AeonWatches.API.Data.Repositories;

public interface IAccountRepository
{
    void AddUser(AppUser user);
    Task<bool> SaveAllAsync();
    Task<bool> UserExists(string username);
    Task<AppUser> UserExists(LoginDto loginDto);
}