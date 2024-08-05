using Microsoft.AspNetCore.Mvc;
using TariffCalculator.Application.DTOs;
using TariffCalculator.Application.Extensions;
using TariffCalculator.Application.Interfaces.ExternalServices;
using TariffCalculator.Domain.Interfaces.DomainServices;

namespace TariffCalculator.API.Controllers;

[ApiController]
[Route("[controller]")]
public class TariffController
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
    public async Task<List<ProductDetailsDto>> GetProductComparison(int yearlyUsage)
    {
        var tariffList = await _externalTariffProvider.GetTariffList();
        return _productComparisonService
            .GetProductComparison(tariffList, yearlyUsage)
            .ToProductDetailsListDto();
    }

}