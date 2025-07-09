using AeonWatches.API.Entities.WatchEntities;
using System.Diagnostics.CodeAnalysis;

namespace AeonWatches.API.Data.SeedData.Watch;


public static class BrandSeedData
{
    public static List<Brand> GetBrandSeedData()
    {
        return new List<Brand>()
        {
            new()
            {
                Name = "Seiko"
            },
            new()
            {
                Name = "Casio"
            },
            new()
            {
                Name = "Grand Seiko"
            },
            new()
            {
                Name = "Orient"
            },
            new()
            {
                Name = "Citizen"
            },
        };
    }
}