
using AeonWatches.API.DTOs.OrderDTOs;
using AeonWatches.API.Entities.OrderEntities;
using AeonWatches.API.Entities.UserEntities;
using AutoMapper;

namespace AeonWatches.API.Helpers.Automapper;

public static class UserMappings
{
    public static void AddUserMappings(this Profile profile)
    {
        profile.CreateMap<CustomerDetail, CustomerDetailDto>();
        profile.CreateMap<CustomerDetailDto, CustomerDetail>();
        profile.CreateMap<AppUser, OrderHistoryDto>();
    }
}