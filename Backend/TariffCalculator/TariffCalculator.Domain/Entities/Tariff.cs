namespace TariffCalculator.Domain.Entities;

/// <summary>
/// Tariff base class.
/// Tariff Type classes inherit from this class, to promote resiliency and possible changes
/// </summary>
public abstract class Tariff
{
    public string Name { get; set; }
    public int Type { get; set; }
    
    /// <summary>
    /// The base cost for the tariff plan (in Euros).
    /// <br></br>
    /// Can be monthly or yearly cost depending on tariff type.
    /// </summary>
    public decimal BaseCost { get; set; }
    
    /// <summary>
    /// The additional kWh Cost for the tariff plan (in cents/kWh)
    /// </summary>
    public decimal AdditionalKwhCost { get; set; }
    
    /// <summary>
    /// Abstract Method for calculating Yearly Cost based on yearly electricity usage
    /// </summary>
    /// <param name="yearlyUsage">An Integer number of kWh/Year</param>
    /// <returns></returns>
    public abstract decimal CalculateYearlyCost(int yearlyUsage);
}