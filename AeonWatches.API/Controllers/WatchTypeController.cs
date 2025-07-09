﻿using AeonWatches.API.Data.Repositories;
using AeonWatches.API.Entities.WatchEntities;
using Microsoft.AspNetCore.Mvc;

namespace AeonWatches.API.Controllers;

public class WatchTypeController : BaseApiController
{
    private readonly IWatchTypeRepository _watchTypeRepository;

    public WatchTypeController(IWatchTypeRepository watchTypeRepository)
    {
        _watchTypeRepository = watchTypeRepository;
    }
        
    [HttpGet]
    public async Task<ActionResult<IEnumerable<WatchType>>> GetWatchTypes()
    {
        var watchTypes = await _watchTypeRepository.GetWatchTypes();
        
        return Ok(watchTypes); 
    }
}