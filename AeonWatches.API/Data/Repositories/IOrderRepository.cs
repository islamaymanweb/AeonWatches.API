

using AeonWatches.API.DTOs.OrderDTOs;
using AeonWatches.API.Entities.OrderEntities;
using AeonWatches.API.Helpers.Pagination;

namespace AeonWatches.API.Data.Repositories;

public interface IOrderRepository
{
    Task<IEnumerable<Order>> GetOrders();
    Task<Order> GetOrderById(int id);
    Task<SuccessOrderDto> GetSuccessOrderById(int id);
    Task<SuccessOrderDto> GetSuccessOrderByOrderIdAndUserId(int orderId, int userId);
    Task<PagedList<OrderHistoryDto>> GetUserOrderHistoryByUserId(int userId, UserParams userParams);
    Task<IEnumerable<Order>> GetOrdersByStatus(int statusId);
    Task<bool> SaveAllAsync();
    void CreateOrder(Order order);
    Task UpdateOrder(Order order);
    Task DeleteOrder(Order order);
}