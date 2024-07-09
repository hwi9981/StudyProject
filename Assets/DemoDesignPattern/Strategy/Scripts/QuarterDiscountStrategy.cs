namespace Strategy
{
	public class QuarterDiscountStrategy : IPromoteStrategy
	{
		public double DoDiscount(double price)
		{
			return price * 0.75f;
		}
	}
}