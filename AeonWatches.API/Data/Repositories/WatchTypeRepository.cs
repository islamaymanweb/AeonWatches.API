﻿
using AeonWatches.API.Entities.WatchEntities;
using Microsoft.EntityFrameworkCore;

namespace AeonWatches.API.Data.Repositories;

public class WatchTypeRepository : IWatchTypeRepository
{
    private readonly DataContext _context;

    public WatchTypeRepository(DataContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<WatchType>> GetWatchTypes()
    {
        return await _context.WatchTypes.AsNoTracking().ToListAsync();
    }

    public async Task<bool> WatchTypeExists(int id)
    {
        return await _context.WatchTypes.AnyAsync(x => x.Id == id);
    }

    public async Task<bool> WatchTypeExists(string watchType)
    {
        return await _context.WatchTypes.AnyAsync(x => x.Type == watchType);
    }
}