namespace StrategyAlpha
{
    public class UpsShippingStrategy : IShippingCostCalculationStrategy
    {
        public decimal Calculate(decimal rawPrice)
        {
            return rawPrice * 1.11m;
        }
    }
}