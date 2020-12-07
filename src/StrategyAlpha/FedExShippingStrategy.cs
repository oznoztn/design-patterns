namespace StrategyAlpha
{
    public class FedExShippingStrategy : IShippingCostCalculationStrategy
    {
        public decimal Calculate(decimal rawPrice)
        {
            return rawPrice * 1.33m;
        }
    }
}