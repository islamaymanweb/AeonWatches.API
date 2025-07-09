using AeonWatches.API.Entities.WatchEntities;
using System.Diagnostics.CodeAnalysis;


namespace AeonWatches.API.Data.SeedData.Watch;

public static class CrystalSeedData
{
    public static List<Crystal> GetCrystalSeedData()
    {
        return new List<Crystal>()
        {
            new()
            {
                Material = "Hardlex"
            },
            new()
            {
                Material = "Sapphire"
            },
            new()
            {
                Material = "Acrylic"
            },
            new()
            {
                Material = "Mineral"
            }
        };
    }
}