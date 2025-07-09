
using AeonWatches.API.Data.Repositories;
using AeonWatches.API.Entities.WatchEntities;
using Microsoft.AspNetCore.Mvc;

namespace AeonWatches.API.Controllers;

public class BrandController : BaseApiController
{
    private readonly IBrandRepository _brandRepository;

    public BrandController(IBrandRepository brandRepository)
    {
        _brandRepository = brandRepository;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Brand>>> GetWatchBrands()
    {
        var brands = await _brandRepository.GetBrands();

        return Ok(brands);
    }
}