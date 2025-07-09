
using AeonWatches.API.Entities.OrderEntities;

namespace AeonWatches.API.Services;

public interface ICustomerService
{
    Order UpdateAndAddCustomerDetailToExistingUser(int appUserId, Order order);
}