namespace StrategyAlpha
{
    public interface IShippingCostCalculationStrategy
    {
        decimal Calculate(decimal rawPrice);
    }
}