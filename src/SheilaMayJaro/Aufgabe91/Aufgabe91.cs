using System.Text;

namespace Appdevhb25.SheilaMayJaro.Aufgabe91

{
    public class Aufgabe91
    {
        public static void Start()
        {
            Console.OutputEncoding = Encoding.Default;
            System.Console.WriteLine("Aufgabe 91)");
            ShoppingBasket groceryShopping = new ShoppingBasket();
            groceryShopping.AddProduct(new Product("Apfel", 1.25), new ShoppingBasketItemNumber(4));
            groceryShopping.AddProduct(new Product("Wassermelone", 2.80), new ShoppingBasketItemNumber(1)); 
            groceryShopping.AddProduct(new Product("Milch", 2.10), new ShoppingBasketItemNumber(2)); 
            groceryShopping.DisplayShoppingBasket(); 
            groceryShopping.RemoveProduct(new Product("Wassermelone", 2.80)); 
            groceryShopping.AddProduct(new Product("Banane", 1.60), new ShoppingBasketItemNumber(4)); 
            groceryShopping.ModifyProduct(new Product("Milch",2.10), 4);
            groceryShopping.AddProduct(new Product("Semmel", 0.60), new ShoppingBasketItemNumber(6));
            CheckOut cashRegister = new CheckOut(); 
            cashRegister.PaymentProcess(groceryShopping);
            ShoppingBasket groceryshopping1 = new ShoppingBasket(); 
            groceryshopping1.AddProduct(new Product("Müsli", 4.99), new ShoppingBasketItemNumber(2)); 
            groceryshopping1.AddProduct(new Product("Milchschnittepackung", 5.99), new ShoppingBasketItemNumber(1)); 
            groceryshopping1.AddProduct(new Product("10-Eierpackung", 3.49), new ShoppingBasketItemNumber(1));
            cashRegister.PaymentProcess(groceryshopping1);
            Console.WriteLine($"Der Tagesumsatz beträgt: {cashRegister.DailyRevenue}€");  
        }
    }
}