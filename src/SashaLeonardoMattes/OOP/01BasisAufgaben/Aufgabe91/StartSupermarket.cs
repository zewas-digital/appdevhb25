using System;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe91
{
    public class SupermarketCreator
    {

        public static void Start()
        {
            Helper.WriteHyphen(System.Reflection.MethodBase.GetCurrentMethod()?.DeclaringType!);

            Product p1 = new Product("p1", 1);
            Product p2 = new Product("p2", 2);
            Product p3 = new Product("p3", 3);

            ShoppingCart shoppingCart = new ShoppingCart();
            shoppingCart.AddItem(p1, 10);
            shoppingCart.AddItem(p2, 10);
            shoppingCart.AddItem(p3, 10);
            shoppingCart.PrintShoppingCart();

            CashRegister c1 = new CashRegister();
            c1.Pay(shoppingCart.shoppingCart);
            System.Console.WriteLine("\nKassa 1: " + c1.dailyRevenue +"\n");

            shoppingCart.RemoveItem(p1);
            shoppingCart.EditItem(p2, 20);
            shoppingCart.PrintShoppingCart();
        }

        
        
    }
}
