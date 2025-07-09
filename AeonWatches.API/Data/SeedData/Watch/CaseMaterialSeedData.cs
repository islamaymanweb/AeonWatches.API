using AeonWatches.API.Entities.WatchEntities;
using System.Diagnostics.CodeAnalysis;


namespace AeonWatches.API.Data.SeedData.Watch;


public static class CaseMaterialSeedData
{
    public static List<CaseMaterial> GetCaseMaterialSeedData()
    {
        return new List<CaseMaterial>()
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
            }
        };
    }
}