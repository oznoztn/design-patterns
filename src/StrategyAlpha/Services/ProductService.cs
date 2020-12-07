namespace StrategyAlpha.Services
{
    public class ProductService
    {
        private readonly IShippingCostCalculationStrategy _shippingCostCalculationStrategy;

        public ProductService(IShippingCostCalculationStrategy shippingCostCalculationStrategy)
        {
            _shippingCostCalculationStrategy = shippingCostCalculationStrategy;
        }

        public decimal CalculateShippingCost()
        {
            const decimal standardShippingCost = 10m;

            return _shippingCostCalculationStrategy.Calculate(standardShippingCost);
        }
    }
}