using TariffCalculator.Domain.Entities;

namespace TariffCalculator.Application.Interfaces.ExternalServices
{
    /// <summary>
    /// Interface for for specifying ExternalTariffProvider behaviour.
    /// This Provider is responsible for fetching tariff lists.
    /// </summary>
    public interface IExternalTariffProvider
    {
        public Task<List<Tariff>> GetTariffList();
    }
}
