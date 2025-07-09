﻿

using AeonWatches.API.Entities.WatchEntities;

namespace AeonWatches.API.Data.Repositories;

public interface IBrandRepository
{
    Task<IEnumerable<Brand>> GetBrands();
    Task<bool> BrandExists(int id);
    Task<bool> BrandExists(string brand);
}