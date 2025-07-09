using AeonWatches.API.Entities.OrderEntities;
using System.Diagnostics.CodeAnalysis;


namespace AeonWatches.API.Data.SeedData.Order;


public static class StatusTypeSeedData
{
    public static List<StatusType> GetStatusTypeSeedData()
    {
        return new List<StatusType>()
        {
            new()
            {
                Status = "Order Confirmed"
            },
            new()
            {
                Status = "Processing"
            },
            new()
            {
                Status = "Shipped"
            },
            new()
            {
                Status = "Delivered"
            },
            new()
            {
                Status = "Cancelled"
            },
            new()
            {
                Status = "Refunded"
            }
        };
    }
}