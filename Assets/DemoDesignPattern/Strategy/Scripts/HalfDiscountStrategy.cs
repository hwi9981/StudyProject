namespace Strategy
{
    public class HalfDiscountStrategy : IPromoteStrategy
    {
        public double DoDiscount(double price)
        {
            return price * 0.5f;
        }
    }
}
