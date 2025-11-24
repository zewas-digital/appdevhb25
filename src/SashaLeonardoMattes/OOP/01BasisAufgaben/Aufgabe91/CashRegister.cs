using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using Appdevhb25.SashaLeonardoMattes.Aufgabe11;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe91
{

    public class CashRegister
    {
        public decimal dailyRevenue;

        public void Pay(List<ShoppingCartItem> products)
        {
            foreach (var item in products)
            {
                dailyRevenue += item.product.Price*item.Amount;
            }
        }
        
    }
}
