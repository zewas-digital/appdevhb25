namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe91
{
    public class ShoppingCart
    {
        public static Dictionary<string, int> shoppingCart = new Dictionary<string, int>();
        public static decimal totalValue = 0;

        public static void Start()
        {
            Supermarkt.Product();
            while (true)
            {

                Console.WriteLine("Hallo Kunde, möchtest du was kaufen? ja oder nein");
                string answer = Console.ReadLine() ?? string.Empty;
                if (answer == "ja")
                {
                    ShoppingCartPerPerson();
                }
                else if (answer == "nein")
                {
                    DailyTurnOver();
                    break;
                }
            }
        }
        public static void ShoppingCartPerPerson()
        {
            totalValue = 0;
            while (true)
            {
                Console.WriteLine("Möchtest du noch was kaufen? ja oder nein    Oder möchtest du was löschen? löschen");
                string answer = Console.ReadLine() ?? string.Empty;
                if (answer == "ja")
                {
                    AddProduct();
                }
                else if (answer == "löschen")
                {
                    DeleteProduct();
                }
                else if (answer == "nein")
                {
                    Pay();
                    break;
                }
            }
        }
        public static void AddProduct()
        {
            Console.WriteLine("Gib ein Produkt an, das du kaufen willst");
            string personProduct = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("Gib die Menge des Produkts an");
            int personAmount = Convert.ToInt32(Console.ReadLine() ?? string.Empty);

            Console.WriteLine("Das ist der aktualisierte Warenkorb:");
            shoppingCart.Add(personProduct, personAmount);
            foreach (KeyValuePair<string, int> sC in shoppingCart)
            {
                Console.WriteLine(sC.Key + " x " + sC.Value);
            }

            foreach (KeyValuePair<string, decimal> product in Supermarkt.products)
            {
                if (product.Key == personProduct)
                {
                    totalValue = totalValue + (product.Value * personAmount);
                }
            }
            Console.WriteLine("Das ist der Gesamtpreis momentan: " + totalValue);
        }
        public static void DeleteProduct()
        {
            Console.WriteLine("Was möchtest du löschen?");
            string deleteProduct = Console.ReadLine() ?? string.Empty;

            int deleteAmount = shoppingCart[deleteProduct];
            shoppingCart.Remove(deleteProduct);
            foreach (KeyValuePair<string, decimal> product in Supermarkt.products)
            {
                if (product.Key == deleteProduct)
                {
                    totalValue = totalValue - (product.Value * deleteAmount);
                }
            }
            Console.WriteLine("Das ist der aktualisierte Warenkorb:");

            foreach (KeyValuePair<string, int> sC in shoppingCart)
            {
                Console.WriteLine(sC.Key + " x " + sC.Value);
            }
            Console.WriteLine("Das ist der Gesamtpreis momentan: " + totalValue);
        }
        public static void Pay()
        {
            Console.WriteLine("Bei welcher Kasse möchtest du bezahlen? 1, 2 oder 3");
            string answer = Console.ReadLine() ?? string.Empty;
            if (answer == "1")
            {
                Kasse.DailyTurnoverCheckout1(totalValue);
            }
            else if (answer == "2")
            {
                Kasse.DailyTurnoverCheckout2(totalValue);
            }
            else if (answer == "3")
            {
                Kasse.DailyTurnoverCheckout3(totalValue);
            }
            shoppingCart.Clear();
        }
        public static void DailyTurnOver()
        {
            Console.WriteLine("Tagesumsatz der ersten Kasse: " + Kasse.DailyTurnOver1());
            Console.WriteLine("Tagesumsatz der zweiten Kasse: " + Kasse.DailyTurnOver2());
            Console.WriteLine("Tagesumsatz der dritten Kasse: " + Kasse.DailyTurnOver3());
        }

    }
}