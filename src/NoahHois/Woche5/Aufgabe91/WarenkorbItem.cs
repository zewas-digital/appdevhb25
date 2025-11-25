using Appdevhb25.NoahHois.Aufgabe91;

namespace Appdevhb25.NoahHois.aufgabe91
{
    public class WarenkorbItem
    {
        public int Quantity;
        public Produkt Product;
        public WarenkorbItem(int quantity, Produkt product)
        {
            Quantity = quantity;
            Product = product;
        }
    }
}