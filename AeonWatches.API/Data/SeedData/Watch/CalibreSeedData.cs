using AeonWatches.API.Entities.WatchEntities;
using System.Diagnostics.CodeAnalysis;


namespace AeonWatches.API.Data.SeedData.Watch;

public static class CalibreSeedData
{
    public static List<Calibre> GetCalibreSeedData()
    {
        return new List<Calibre>()
        {
            new()
            {
                Name = "Calibre1"
            },
            new()
            {
                Name = "Calibre2"
            },
            new()
            {
                Name = "Calibre3"
            }
        };
    }
}