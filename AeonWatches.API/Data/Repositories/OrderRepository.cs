﻿
using AeonWatches.API.DTOs.OrderDTOs;
using AeonWatches.API.Entities.OrderEntities;
using AeonWatches.API.Helpers.Pagination;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace AeonWatches.API.Data.Repositories;

public class OrderRepository : IOrderRepository
{
    private readonly DataContext _context;
    private readonly IMapper _mapper;

    public OrderRepository(DataContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<IEnumerable<Order>> GetOrders()
    {
        return await _context.Orders
            .Include(o => o.CustomerDetail)
            .Include(o => o.StatusType)
            .Include(o => o.Items)
            .ThenInclude(i => i.ItemType)
            .AsNoTracking().ToListAsync();
    }

    public async Task<Order> GetOrderById(int id)
    {
        return await _context.Orders
            .Include(o => o.CustomerDetail)
            .Include(o => o.StatusType)
            .Include(o => o.Items)
            .ThenInclude(i => i.ItemType)
            .SingleOrDefaultAsync(o => o.Id == id);
    }

    public async Task<SuccessOrderDto> GetSuccessOrderById(int id)
    {
        return await _context.Orders
            .Where(x => x.Id == id)
            .AsNoTracking()
            .ProjectTo<SuccessOrderDto>(_mapper.ConfigurationProvider)
            .SingleOrDefaultAsync();
    }

    public async Task<SuccessOrderDto> GetSuccessOrderByOrderIdAndUserId(int orderId, int userId)
    {
        return await _context.Orders
            .Where(x => x.Id == orderId && x.CustomerDetail.AppUserId == userId)
            .AsNoTracking()
            .ProjectTo<SuccessOrderDto>(_mapper.ConfigurationProvider)
            .SingleOrDefaultAsync();
    }

    public async Task<PagedList<OrderHistoryDto>> GetUserOrderHistoryByUserId(int userId, UserParams userParams)
    {
        var query = _context.Orders.AsQueryable()
            .Where(c => c.CustomerDetail.AppUserId == userId)
            .OrderByDescending(x => x.DateTime)
            .ProjectTo<OrderHistoryDto>(_mapper.ConfigurationProvider)
            .AsNoTracking();
        
        return await PagedList<OrderHistoryDto>.CreateAsync(query, userParams.PageNumber, userParams.PageSize);
    }

    public async Task<IEnumerable<Order>> GetOrdersByStatus(int statusId)
    {
        return await _context.Orders.Where(w => w.StatusTypeId == statusId)
            .Include(o => o.CustomerDetail)
            .Include(o => o.StatusType)
            .Include(o => o.Items)
            .ThenInclude(i => i.ItemType)
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<bool> SaveAllAsync()
    {
        return await _context.SaveChangesAsync() > 0;
    }

    public void CreateOrder(Order order)
    {
        _context.Orders.Add(order);
    }

    public Task UpdateOrder(Order order)
    {
        throw new NotImplementedException();
    }

    public Task DeleteOrder(Order order)
    {
        throw new NotImplementedException();
    }
}