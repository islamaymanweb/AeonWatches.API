﻿using AeonWatches.API.DTOs.OrderDTOs;
using AeonWatches.API.Entities.OrderEntities;
using AutoMapper;

namespace AeonWatches.API.Helpers.Automapper;

public static class OrderMappings
{
    public static void AddOrderMappings(this Profile profile)
    {
        profile.CreateMap<OrderDto, Order>();
        profile.CreateMap<CustomerDetailDto, CustomerDetail>();
        profile.CreateMap<ItemDto, Item>();
        profile.CreateMap<Order, SuccessOrderDto>()
            .ForMember(dest => dest.StatusType,
                opt => opt.MapFrom(src => src.StatusType.Status));
        profile.CreateMap<CustomerDetail, CustomerDetailDto>();
        profile.CreateMap<Item, ItemDto>();
        profile.CreateMap<Order, OrderHistoryDto>()
            .ForMember(dest => dest.StatusType,
                opt => opt.MapFrom(src => src.StatusType.Status));
    }
}