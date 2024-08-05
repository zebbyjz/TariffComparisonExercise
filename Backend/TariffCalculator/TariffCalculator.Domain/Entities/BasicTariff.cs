using TariffCalculator.Domain.Constants;

namespace TariffCalculator.Domain.Entities;

/// <summary>
/// Basic Tariff derived class.
/// </summary>
public class BasicTariff : Tariff
{
    /// <summary>
    /// Concrete Method for calculating Yearly Cost for Basic Tariff (type 1) based on yearly electricity usage
    /// </summary>
    /// <param name="yearlyUsage">An Integer number of kWh/Year</param>
    /// <returns></returns>
    public override decimal CalculateYearlyCost(int yearlyUsage)
    {
        decimal totalCost;
        decimal totalBaseCosts = GeneralConstants.MonthsInAYear * BaseCost;
        decimal totalConsumptionCosts = (yearlyUsage * AdditionalKwhCost) / GeneralConstants.CentsInAEuro;

        totalCost = totalBaseCosts + totalConsumptionCosts;
        return totalCost;
    }
}