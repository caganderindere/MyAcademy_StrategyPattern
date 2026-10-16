namespace StrategyDesignPattern.Web.StrategyPattern
{
    public class YurticiShippingStrategy : IShippingStrategy
    {
        public string CompanyName => "Yurtici Kargo";

        //sipariş tutarının %10'u + 20 TL sabit ücret
        public decimal CalculateCost(decimal orderTotal)
        {
            return (orderTotal * 0.10m) + 20;


        }
    }
}
