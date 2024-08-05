namespace TariffCalculator.Domain.ServicesResult;

public class ProductDetailsResult
{
    public string Name { get; set; }
    public decimal BaseCost { get; set; }
    public decimal AdditionalKwhCost { get; set; }
    
    public decimal YearlyCost { get; set; }
}