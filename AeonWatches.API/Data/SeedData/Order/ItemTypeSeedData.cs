using AeonWatches.API.Entities.OrderEntities;
using System.Diagnostics.CodeAnalysis;

namespace AeonWatches.API.Data.SeedData.Order;


public static class ItemTypeSeedData
{
    public static List<ItemType> GetItemTypeSeedData()
    {
        return new List<ItemType>()
        {
            new()
            {
                Type = "Watch"
            },
            new()
            {
                Type = "Strap"
            },
            new()
            {
                Type = "Case"
            }
        };
    }
}