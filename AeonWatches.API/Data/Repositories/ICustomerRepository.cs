

using AeonWatches.API.Entities.OrderEntities;

namespace AeonWatches.API.Data.Repositories;

public interface ICustomerRepository
{
    Task<CustomerDetail> GetCustomerDetailByAppUserId(int appUserId);
}