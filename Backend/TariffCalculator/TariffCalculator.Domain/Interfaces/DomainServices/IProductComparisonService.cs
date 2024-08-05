using TariffCalculator.Domain.Entities;
using TariffCalculator.Domain.ServicesResult;

namespace TariffCalculator.Domain.Interfaces.DomainServices;

public interface IProductComparisonService
{
    public List<ProductDetailsResult> GetProductComparison(List<Tariff> tariffs , int yearlyUsage);
}