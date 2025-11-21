using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using Appdevhb25.SashaLeonardoMattes.Aufgabe11;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe91
{

    public class ShoppingCartItem
    {
        public Product product = new Product();
        public int Amount;

        public ShoppingCartItem(Product p, int amount)
        {
            product = p;
            Amount = amount;
        }
    }
}
