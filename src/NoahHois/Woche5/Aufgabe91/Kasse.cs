namespace Appdevhb25.NoahHois.Aufgabe91
{
    public class Kasse
    {
        public double DailySales = 0;
        public void Pay(Warenkorb shoppingCart)
        {
            DailySales += shoppingCart.TotalPrice();
            shoppingCart.Clear();
        }

    }
}