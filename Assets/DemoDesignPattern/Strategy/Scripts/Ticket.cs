using System;

namespace Strategy
{
    public class Ticket
    {
        private IPromoteStrategy m_PromoteStrategy;
        private double m_Price;
        private string m_Name;

        public IPromoteStrategy GetPromoteStrategy() => m_PromoteStrategy;
        public void SetPromoteStrategy(IPromoteStrategy value) => m_PromoteStrategy = value;
    
        public double GetPrice() => m_Price;
        public void SetPrice(double value) => m_Price = value;
    
        public string GetName() => m_Name;
        public void SetName(string value) => m_Name = value;

        public Ticket() {}
    
        public Ticket(IPromoteStrategy promoteStrategy)
        {
            m_PromoteStrategy = promoteStrategy;
        }

        public double GetPromotedPrice()
        {
            return m_PromoteStrategy.DoDiscount(m_Price);
        }
    }
}