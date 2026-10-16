namespace StrategyDesignPattern.Web.Models
{
    public class OrderViewModel
    {
        public decimal OrderTotal { get; set; }

        public string SelectCargo { get; set; }

        public decimal? CalculatedShippingCost { get; set; }

        public decimal? GrandTotal => OrderTotal + (CalculatedShippingCost ?? 0);
    }
}
