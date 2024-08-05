using TariffCalculator.Domain.Entities;
using TariffCalculator.Domain.Interfaces.DomainServices;
using TariffCalculator.Domain.ServicesResult;

namespace TariffCalculator.Domain.DomainServices;

public class ProductComparisonService : IProductComparisonService
{
    public List<ProductDetailsResult> GetProductComparison(List<Tariff> tariffs, int yearlyUsage)
    {
        return tariffs.Select(tariff =>
            new ProductDetailsResult()
            {
                Name = tariff.Name,
                BaseCost = tariff.BaseCost,
                AdditionalKwhCost = tariff.AdditionalKwhCost,
                YearlyCost = tariff.CalculateYearlyCost(yearlyUsage)
            }
        ).ToList();
    }
}