namespace StrategyAlpha
{
    public class FooBarBaxExShippingStrategy : IShippingCostCalculationStrategy
    {
        public decimal Calculate(decimal rawPrice)
        {
            return rawPrice;
        }
    }
}