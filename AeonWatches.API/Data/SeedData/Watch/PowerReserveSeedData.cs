using System.Diagnostics.CodeAnalysis;

using AeonWatches.API.Entities.WatchEntities;

namespace AeonWatches.API.Data.SeedData.Watch;


public static class PowerReserveSeedData
{
    public static List<PowerReserve> GetPowerReserveSeedData()
    {
        return new List<PowerReserve>()
        {
            new()
            {
                Duration = 36
            },
            new()
            {
                Duration = 42
            },
            new()
            {
                Duration = 48
            }
        };
    }
}