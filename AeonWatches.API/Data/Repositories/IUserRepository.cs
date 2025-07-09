

using AeonWatches.API.DTOs.OrderDTOs;
using AeonWatches.API.Entities.OrderEntities;
using AeonWatches.API.Entities.UserEntities;

namespace AeonWatches.API.Data.Repositories;

public interface IUserRepository
{
    Task<IEnumerable<AppUser>> GetUsers();
    Task<AppUser> GetUserById(int id);
    Task<CustomerDetailDto> GetCustomerDetailByUserId(int userId);
    void AddCustomerDetail(CustomerDetail customerDetail, int userId);
    void SetCustomerDetailIsMainToFalse(int userId);
    Task<bool> SaveAllAsync();
}