using System.Net;
using Microsoft.AspNetCore.Mvc;
using TariffCalculator.Application.DTOs;
using TariffCalculator.Application.Extensions;
using TariffCalculator.Application.Interfaces.ExternalServices;
using TariffCalculator.Domain.Interfaces.DomainServices;

namespace TariffCalculator.API.Controllers;

[ApiController]
[Route("[controller]")]
public class TariffController : ControllerBase
{
    private readonly ILogger<TariffController> _logger;
    private readonly IExternalTariffProvider _externalTariffProvider;
    private readonly IProductComparisonService _productComparisonService;
    
    public TariffController(ILogger<TariffController> logger,
        IExternalTariffProvider externalTariffProvider,
        IProductComparisonService productComparisonService
    )
    {
        _logger = logger;
        _externalTariffProvider = externalTariffProvider;
        _productComparisonService = productComparisonService;
    }
    
    
    [HttpGet(Name = "GetProductComparison")]
    [ProducesResponseType(typeof(List<ProductDetailsDto>),(int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.BadRequest)]
    [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
    // public async Task<ActionResult<List<ProductDetailsDto>>> GetProductComparison(int yearlyUsage)
    public async Task<IActionResult> GetProductComparison(int yearlyUsage)
    {
        if (yearlyUsage <= 0)
        {
            return BadRequest(ResponseMessages.YearlyUsageCannotBeLessThanZero);
        }
        
        try
        {
            var tariffList = await _externalTariffProvider.GetTariffList();
            var result = _productComparisonService
                .GetProductComparison(tariffList, yearlyUsage)
                .ToProductDetailsListDto();
            
            if (result != null) return Ok(result);
            return NotFound();
        }
        catch (Exception e)
        {
            _logger.LogError(e,e.Message);
            return StatusCode(StatusCodes.Status500InternalServerError, ResponseMessages.InternalServerError);
        }
    }

}