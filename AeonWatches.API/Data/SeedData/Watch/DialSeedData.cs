using System.Diagnostics.CodeAnalysis;
using AeonWatches.API.Entities.WatchEntities;
 namespace AeonWatches.API.Data.SeedData.Watch;


public static class DialSeedData
{
    public static List<Dial> GetDialSeedData()
    {
        return new List<Dial>()
        {
            new()
            {
                Colour = "Black"
            },
            new()
            {
                Colour = "White"
            },
            new()
            {
                Colour = "Blue"
            },
            new()
            {
                Colour = "Red"
            },
            new()
            {
                Colour = "Yellow"
            },
            new()
            {
                Colour = "Green"
            },
            new()
            {
                Colour = "Pink"
            },
            new()
            {
                Colour = "Light blue"
            },
            new()
            {
                Colour = "Grey"
            },
            new()
            {
                Colour = "Silver"
            },
            new()
            {
                Colour = "Gold"
            }
        };
    }
}