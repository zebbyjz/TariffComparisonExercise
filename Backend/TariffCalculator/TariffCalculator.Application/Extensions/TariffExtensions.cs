using TariffCalculator.Application.DTOs;
using TariffCalculator.Domain.Entities;
using TariffCalculator.Domain.ServicesResult;

namespace TariffCalculator.Application.Extensions;

public static class TariffExtensions
{
    public static List<ProductDetailsDto> ToProductDetailsListDto(this List<ProductDetailsResult> productDetails)
    {
        return productDetails
        .Select(productDetail => new ProductDetailsDto()
        {
            Name = productDetail.Name,
            BaseCost = productDetail.BaseCost,
            AdditionalKwhCost = productDetail.AdditionalKwhCost,
            YearlyCost = productDetail.YearlyCost
        })
        .ToList();
    }
}