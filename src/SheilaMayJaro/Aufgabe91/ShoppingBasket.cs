using System.ComponentModel;

namespace Appdevhb25.SheilaMayJaro.Aufgabe91
{
    public class ShoppingBasket
    {
        public Dictionary<Product, ShoppingBasketItemNumber> ShoppingList = new Dictionary<Product, ShoppingBasketItemNumber>();
        public void AddProduct(Product product, ShoppingBasketItemNumber item)
        {
            ShoppingList.Add(product, item);
            DisplayShoppingBasket(); 
        }
        public void RemoveProduct(Product product)
        {
            ShoppingList.Remove(product);
            DisplayShoppingBasket(); 
        }
        public void ModifyProduct(Product product, int amount)
        {
            foreach (KeyValuePair<Product, ShoppingBasketItemNumber> item in ShoppingList)
            {
                if (product == item.Key)
                {
                    item.Value.Amount = amount;
                }
            }
            DisplayShoppingBasket(); 
        }
        public void DisplayShoppingBasket()
        {
            System.Console.WriteLine("\nIm Warenkorb befindet sich:");
            foreach (KeyValuePair<Product,ShoppingBasketItemNumber> item in ShoppingList)
            {
                System.Console.WriteLine($"\n\tArtikel: {item.Key.Name}\n\tPreis: {item.Key.Price}€\n\tMenge: {item.Value.Amount}");
            }
            Console.WriteLine($"Gesamtpreis der Artikel im Warenkorb: {TotalValue():N2}"); 
        }
        public double TotalValue()
        {
            double totalValue = 0;
            foreach (KeyValuePair<Product,ShoppingBasketItemNumber> item in ShoppingList)
            {
                totalValue += item.Key.Price * item.Value.Amount; 
            }
            return totalValue;
        }
    }
}