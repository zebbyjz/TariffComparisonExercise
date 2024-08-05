using TariffCalculator.Domain.Constants;

namespace TariffCalculator.Domain.Entities;

/// <summary>
/// Packaged Tariff derived class.
/// </summary>
public class PackagedTariff : Tariff
{
    /// <summary>
    /// Number of units included in the package.
    /// <br></br>
    /// Going above this limit incurs extra cost dependent upon additionalKwhCost
    /// </summary>
    public int IncludedKwh { get; set; }
    
    /// <summary>
    /// Concrete Method for calculating Yearly Cost for Packaged Tariff (type 2) based on yearly electricity usage
    /// </summary>
    /// <param name="yearlyUsage">An Integer number of kWh/Year</param>
    /// <returns></returns>
    public override decimal CalculateYearlyCost(int yearlyUsage)
    {
        decimal totalCost;
        
        if (yearlyUsage <= IncludedKwh)
        {
            //If consumption is within the limits of Included units, then total yearly cost is simply the price of Included Units
            totalCost = BaseCost;
        }
        else
        {
            int additionalConsumption = yearlyUsage - IncludedKwh;
            decimal totalAdditionalConsumptionCosts = (additionalConsumption * AdditionalKwhCost) / GeneralConstants.CentsInAEuro;
            totalCost = BaseCost + totalAdditionalConsumptionCosts;
        }
        
        
        return totalCost;
    }
}