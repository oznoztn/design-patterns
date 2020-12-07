using System;
using System.Linq.Expressions;
using StrategyAlpha.Enums;
using StrategyAlpha.Models;
using StrategyAlpha.Services;

namespace StrategyAlpha
{
    class Program
    {
        static void Main(string[] args)
        {
            var piano = new ProductDto()
            {
                Name = "Piano", 
                ShippingCompany = ShippingCompany.FedEx,
            };

            ProductService productService1 = new ProductService(new FedExShippingStrategy());
            var cost1 = productService1.CalculateShippingCost();


            var guitar = new ProductDto
            {
                Name = "Guitar",
                // ShippingCompany = ShippingCompany.Ups
            };

            ProductService productService2 = new ProductService(new UpsShippingStrategy());
            var cost2 = productService2.CalculateShippingCost();
        }
    }
}
