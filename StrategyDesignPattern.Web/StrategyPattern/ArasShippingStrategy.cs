namespace StrategyDesignPattern.Web.StrategyPattern
{
    public class ArasShippingStrategy : IShippingStrategy
    {
        public string CompanyName => "aras kargo";

        // 50 tl sabit ücret
        public decimal CalculateCost(decimal orderTotal)
        {
            return 50m;

        }
    }
}
