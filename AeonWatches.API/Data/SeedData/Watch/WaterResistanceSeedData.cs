﻿using System.Diagnostics.CodeAnalysis;
using AeonWatches.API.Entities.WatchEntities;

namespace AeonWatches.API.Data.SeedData.Watch;
public static class WaterResistanceSeedData
{
    public static List<WaterResistance> GetWaterResistanceSeedData()
    {
        return new List<WaterResistance>()
        {
            new()
            {
                Resistance = 30
            },
            new()
            {
                Resistance = 50
            },
            new()
            {
                Resistance = 100
            },
            new()
            {
                Resistance = 200
            },
            new()
            {
                Resistance = 300
            },
        };
    }
}