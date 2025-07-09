

using AeonWatches.API.DTOs.OrderDTOs;
using AeonWatches.API.Entities.OrderEntities;
using AeonWatches.API.Entities.WatchEntities;

namespace AeonWatches.API.Services;

public interface IOrderService
{
    Task<SuccessOrderDto> PlaceOrder(Order order, List<Watch> watches, int userId);
    decimal ReduceWatchQuantityAndReturnTotalPrice(List<Watch> watches, Order order);
    void AddPriceToOrderItems(List<Watch> watches, Order order);
}