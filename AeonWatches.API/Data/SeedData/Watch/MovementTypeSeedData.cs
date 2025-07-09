using AeonWatches.API.Entities.WatchEntities;
using System.Diagnostics.CodeAnalysis;


namespace AeonWatches.API.Data.SeedData.Watch;


public static class MovementTypeSeedData
{
    public static List<MovementType> GetMovementTypeSeedData()
    {
        return new List<MovementType>()
        {
            new()
            {
                Type = "Automatic"
            },
            new()
            {
                Type = "Manual Winding"
            },
            new()
            {
                Type = "Quartz"
            }
        };
    }
}