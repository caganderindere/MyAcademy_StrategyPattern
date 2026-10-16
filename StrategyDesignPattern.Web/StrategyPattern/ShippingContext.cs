namespace StrategyDesignPattern.Web.StrategyPattern
{
    public class ShippingContext
    {
        private  IShippingStrategy _shippingStrategy;

        public void SetStrategy(IShippingStrategy shippingStrategy)
        {
            _shippingStrategy = shippingStrategy;
        }
        public decimal CalculateShippingCost(decimal orderTotal)
        {
            if (_shippingStrategy == null)
            {
                throw new InvalidOperationException("Kargo Stratejisi Seçin");
            }
            return _shippingStrategy.CalculateCost(orderTotal);
        }

    }
}
