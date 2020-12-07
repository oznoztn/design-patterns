using System;
using StrategyAlpha.Enums;
using StrategyAlpha.Models;

namespace StrategyAlpha.Services
{
    public class ProductService
    {
        public decimal CalculateShippingCost(ProductDto productDto)
        public decimal CalculateShippingCost(ShippingCompany shippingCompany)
        {
            const decimal standardShippingCost = 10m;

            switch (productDto.ShippingCompany)
            switch (shippingCompany)
            {
                case ShippingCompany.Ups:
                    return standardShippingCost * 1.11m;
                case ShippingCompany.FedEx:
                    return standardShippingCost * 1.33m;
                case ShippingCompany.FooBarBazEx:
                    return standardShippingCost;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}