namespace StrategyDesignPattern.Web.StrategyPattern
{
    public class DhlShippingStrategy : IShippingStrategy
    {
        public string CompanyName => "DHL Kargo";

        //500tl üzeri ücretsiz diğerleri 75 tl

        public decimal CalculateCost(decimal orderTotal)
        {
            return orderTotal >= 500m ? 0m : 75m;
        }
    }
}
