namespace Strategy
{
    public class EightyDiscountStrategy : IPromoteStrategy
    {
        public double DoDiscount(double price)
        {
            return price * 0.2f;
        }
    }
}