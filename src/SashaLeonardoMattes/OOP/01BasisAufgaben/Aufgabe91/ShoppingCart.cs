using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using Appdevhb25.SashaLeonardoMattes.Aufgabe11;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe91
{

    public class ShoppingCart
    {
        public List<ShoppingCartItem> shoppingCart = new List<ShoppingCartItem>();
        private decimal totalValue;

        public void AddItem(Product p, int amount)
        {
            shoppingCart.Add(new ShoppingCartItem(p, amount));
            totalValue += p.Price*amount;
        }

        public void RemoveItem(Product p)
        {
            ShoppingCartItem? item = shoppingCart.FirstOrDefault(x => x.product == p);
            if (item != null)
            {
                totalValue -= item.product.Price*item.Amount;
                shoppingCart.Remove(item);
            }
        }

        public void EditItem(Product p, int newAmount)
        {
            ShoppingCartItem? item = shoppingCart.FirstOrDefault(x => x.product == p);
            if (item != null)
            {
                ShoppingCartItem editedItem = new ShoppingCartItem(p, newAmount);
                shoppingCart.Remove(item);
                shoppingCart.Add(editedItem);
            }
            
        }
        
        public void PrintShoppingCart()
        {
            System.Console.WriteLine("--------------------Warenkorb--------------------");
            foreach (var item in shoppingCart)
            {
                System.Console.WriteLine($"Produkt: {item.product.Name}\nPreis: {item.product.Price}\nAnzahl: {item.Amount}\n");
            }
            System.Console.WriteLine("--------------------Warenkorb--------------------");
        }
    }
}
