namespace StrategyDesignPattern.Web.StrategyPattern
{
    public interface IShippingStrategy
    {
        public string CompanyName { get; }

        decimal CalculateCost(decimal orderTotal);


    }
}
