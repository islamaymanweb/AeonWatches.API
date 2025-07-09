using AeonWatches.API.Entities.WatchEntities;
using System.Diagnostics.CodeAnalysis;

namespace AeonWatches.API.Data.SeedData.Watch;


public static class StrapBraceletMaterialSeedData
{
    public static List<StrapBraceletMaterial> GetStrapBraceletMaterialSeedData()
    {
        return new List<StrapBraceletMaterial>()
        {
            new()
            {
                Material = "Stainless Steel"
            },
            new()
            {
                Material = "Ceramic"
            },
            new()
            {
                Material = "Titanium"
            },
            new()
            {
                Material = "Carbon Fibre"
            },
            new()
            {
                Material = "Gold"
            },
            new()
            {
                Material = "Rubber"
            },
            new()
            {
                Material = "Resin"
            },
            new()
            {
                Material = "Leather"
            }
        };
    }
}