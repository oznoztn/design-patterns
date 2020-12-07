using StrategyAlpha.Enums;
using StrategyAlpha.Models;
using StrategyAlpha.Services;

namespace StrategyAlpha
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductService productService = new ProductService();

            var piano = new ProductDto()
            {
                Name = "Piano", 
                ShippingCompany = ShippingCompany.FedEx,
            };

            productService.CalculateShippingCost(piano);

            var guitar = new ProductDto
            {
                Name = "Guitar",
                ShippingCompany = ShippingCompany.Ups
            };
        }
    }
}
