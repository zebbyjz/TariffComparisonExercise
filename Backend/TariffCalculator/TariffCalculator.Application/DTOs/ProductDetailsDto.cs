namespace TariffCalculator.Application.DTOs;

public class ProductDetailsDto
{
    public string Name { get; set; }
    public decimal BaseCost { get; set; }
    public decimal AdditionalKwhCost { get; set; }
    
    public decimal YearlyCost { get; set; }
}