using AeonWatches.API.Entities.WatchEntities;
using System.Diagnostics.CodeAnalysis;


namespace  AeonWatches.API.Data.SeedData.Watch;

public static class WatchTypeSeedData
{
    public static List<WatchType> GetWatchTypeSeedData()
    {
        return new List<WatchType>()
        {
            new()
            {
                Type = "Dress"
            },
            new()
            {
                Type = "GMT"
            },
            new()
            {
                Type = "Chronograph"
            },
            new()
            {
                Type = "Digital"
            },
            new()
            {
                Type = "Solar"
            },
            new()
            {
                Type = "Smart"
            },
            new()
            {
                Type = "Diver"
            },
        };
    }
}