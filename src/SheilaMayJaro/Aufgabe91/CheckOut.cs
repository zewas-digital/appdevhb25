namespace Appdevhb25.SheilaMayJaro.Aufgabe91
{
    public class CheckOut
    {
        private double _dailyRevenue; 
        public double DailyRevenue
        {
            get{return _dailyRevenue;}
            set{_dailyRevenue = value;}
        }
        public double PaymentProcess(ShoppingBasket shoppingBasket)
        {
            _dailyRevenue += shoppingBasket.TotalValue(); 
            return _dailyRevenue; 
        }
    }
}