using Appdevhb25.NoahHois.aufgabe91;

namespace Appdevhb25.NoahHois.Aufgabe91
{
    public class Warenkorb
    {
        List<WarenkorbItem> Items = new();
        public string Customer;
        public Warenkorb(string customer)
        {
            Customer = customer;
        }


        public void Add(Produkt item, int quantities)
        {
            Items.Add(new WarenkorbItem(quantities, item));
        }
        public void Change(Produkt item, int amount)
        {
            foreach (WarenkorbItem i in Items)
            {
                if (i.Product == item)
                {
                    i.Quantity += amount;
                }
            }
        }
        public void Delete(Produkt item)
        {
            foreach (WarenkorbItem i in Items)
            {
                if (i.Product == item)
                {
                    Items.Remove(i); break;
                }
            }
        }

        public double TotalPrice()
        {
            double totalPrice = 0;
            foreach (WarenkorbItem i in Items)
            {
                totalPrice += i.Product.ArticleCost * i.Quantity;
            }
            return totalPrice;
        }

        public void PrintOutput()
        {
            System.Console.WriteLine("-----------------------");

            foreach (WarenkorbItem i in Items)
            {
                double price = i.Quantity * i.Product.ArticleCost;
                System.Console.WriteLine($"{Customer} hat {i.Quantity} {i.Product.ArticleName} die {String.Format("{0:0.00}", price)} kosten.");
            }
            if (Items.Count == 0)
            {
                System.Console.WriteLine("Der Warenkorb ist leer.");
            }
            else
            {
                System.Console.WriteLine($"Gesamtpreis: {String.Format("{0:0.00}", TotalPrice())}");
            }
            System.Console.WriteLine("-----------------------");

        }
        public void Clear()
        {
            Items.Clear();
        }
    }
}