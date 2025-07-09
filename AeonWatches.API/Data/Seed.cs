﻿using System.Diagnostics.CodeAnalysis;
using AeonWatches.API.Data.SeedData.Order;
using AeonWatches.API.Data.SeedData.User;
using AeonWatches.API.Data.SeedData.Watch;
using Microsoft.EntityFrameworkCore;

namespace AeonWatches.API.Data;


public static class Seed
{
    public static async Task SeedWatches(DataContext context)
    {
        if (await context.Watches.AnyAsync()) return;
        
        await context.Brands.AddRangeAsync(BrandSeedData.GetBrandSeedData());
        await context.Calibres.AddRangeAsync(CalibreSeedData.GetCalibreSeedData());
        await context.CaseMaterials.AddRangeAsync(CaseMaterialSeedData.GetCaseMaterialSeedData());
        await context.Crystals.AddRangeAsync(CrystalSeedData.GetCrystalSeedData());
        await context.Dials.AddRangeAsync(DialSeedData.GetDialSeedData());
        await context.MovementTypes.AddRangeAsync(MovementTypeSeedData.GetMovementTypeSeedData());
        await context.PowerReserves.AddRangeAsync(PowerReserveSeedData.GetPowerReserveSeedData());
        await context.StrapBraceletMaterials.AddRangeAsync(StrapBraceletMaterialSeedData.GetStrapBraceletMaterialSeedData());
        await context.WatchCaseMeasurements.AddRangeAsync(WatchCaseMeasurementsSeedData.GetWatchCaseMeasurementsSeedData());
        await context.WatchTypes.AddRangeAsync(WatchTypeSeedData.GetWatchTypeSeedData());
        await context.WaterResistances.AddRangeAsync(WaterResistanceSeedData.GetWaterResistanceSeedData());
        await context.SaveChangesAsync();
        
        await context.Watches.AddRangeAsync(WatchSeedData.GetWatchSeedData());

        await context.SaveChangesAsync();
    }

    public static async Task SeedOrder(DataContext context)
    {
        if (await context.Orders.AnyAsync()) return;
        
        await context.StatusTypes.AddRangeAsync(StatusTypeSeedData.GetStatusTypeSeedData());
        await context.ItemTypes.AddRangeAsync(ItemTypeSeedData.GetItemTypeSeedData());
        await context.CustomerDetails.AddRangeAsync(CustomerDetailSeedData.GetCustomerDetailSeedData());
        await context.SaveChangesAsync();
        
        await context.Orders.AddRangeAsync(OrderSeedData.GetOrderSeedData());
        
        await context.SaveChangesAsync();
    }

    public static async Task SeedUser(DataContext context)
    {
        if (await context.AppUsers.AnyAsync()) return;
        
        await context.AppUsers.AddRangeAsync(UserSeedData.GetUserSeedData());
        
        await context.SaveChangesAsync();
    }
} 