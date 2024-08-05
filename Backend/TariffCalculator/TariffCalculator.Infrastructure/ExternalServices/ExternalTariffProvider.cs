using TariffCalculator.Application.Interfaces.ExternalServices;
using TariffCalculator.Domain.Entities;

namespace TariffCalculator.Infrastructure.ExternalServices;

public class ExternalTariffProvider : IExternalTariffProvider
{
    private List<Tariff> _tariffs;

    public ExternalTariffProvider()
    {
        _tariffs = new List<Tariff>();
        PopulateInternalTariffList();
    }
    
    public Task<List<Tariff>> GetTariffList()
    {
        return Task.FromResult(_tariffs);
    }

    private void PopulateInternalTariffList()
    {
        _tariffs.Add(new BasicTariff()
        {
            Name = "Product A",
            Type = 1,
            BaseCost = 5,
            AdditionalKwhCost = 22
        });
        
        _tariffs.Add(new PackagedTariff()
        {
            Name = "Product B",
            Type = 2,
            IncludedKwh = 4000,
            BaseCost = 800,
            AdditionalKwhCost = 30
            
        });
    }
}