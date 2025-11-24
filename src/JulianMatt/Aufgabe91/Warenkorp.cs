using Appdevhb25.JulianMatt.Aufgabe25;

namespace Appdevhb25.JulianMatt.Aufgabe91
{
    public class Warenkorb
    {
        List<Produkt> ProduktList = new List<Produkt>();

        public string NameOfTheOwnerOfWarenkorp;

        public double TotalPriceOfWarenkorb = 0;

        public void FillWarenkorb()
        {
            string str = new string ('-', 50);

            System.Console.WriteLine(str);
            System.Console.WriteLine();
            System.Console.WriteLine("Wie ist der Name Des Aktuelen Kundens?");

            NameOfTheOwnerOfWarenkorp = Console.ReadLine();

            string input = "ja";
            while (input != "nein")
            {

                double priceOfChoosenGood = 0;
                System.Console.WriteLine($"Was wollen sie kaufen? \n\nZur Auswahl sind \nÄpfel = 1.50 \nBananen = 2.0 \nTrauben = 1.0 \nReis = 5.0");
                string product = Console.ReadLine();

                System.Console.WriteLine($"Wie viele {product} wollen sie Kaufen");
                int amount = Convert.ToInt32(Console.ReadLine());

                bool isHere = IsProductAlreadyHere(product, amount);

                if (isHere == false)
                {
                    priceOfChoosenGood = PriceOfTheProduct(product, amount);

                    TotalPriceOfWarenkorb += priceOfChoosenGood;

                    ProduktList.Add(new Produkt { ChoosenProduct = product, PriceOfProduct = priceOfChoosenGood, CountOfProducts = amount });
                }


                PrintCurrentShoppingCart();

                System.Console.WriteLine(TotalPriceOfWarenkorb);

                System.Console.WriteLine($"Wollen sie ein Weiteres Produkt Hinzufügen (Ja|Nein), fals sie ein Produkt löschen wollen schreiben sie delete");
                while (true)
                {
                    input = Console.ReadLine().ToLower();
                    if (input.ToLower() == "delete")
                    {
                        DeleteProdukt();
                        input = "ja";
                        break;
                    }
                    else if (input.ToLower() == "ja" || input.ToLower() == "nein")
                    {
                        break;
                    }
                    else
                    {
                        System.Console.WriteLine();
                        System.Console.WriteLine("Invalider Input probieren sie es noch einmal");
                        System.Console.WriteLine();
                    }
                }
            }
            System.Console.WriteLine(str);
            System.Console.WriteLine("\n\n");

        }

        public bool IsProductAlreadyHere(string product, int amount)
        {
            Produkt found = ProduktList.FirstOrDefault(p => p.ChoosenProduct.Equals(product, StringComparison.OrdinalIgnoreCase));

            if (found == null)
            {
                return false;
            }

            found.CountOfProducts += amount;

            if (found.CountOfProducts == 0)
            {
                ProduktList.Remove(found);
            }

            TotalPriceOfWarenkorb += PriceOfTheProduct(found.ChoosenProduct, amount);

            found.PriceOfProduct += PriceOfTheProduct(found.ChoosenProduct, amount);

            return true;
        }

        public double PriceOfTheProduct(string product, int amount)
        {
            if (product == "Äpfel")
            {
                return amount * 1.50;
            }
            else if (product == "Bananen")
            {
                return amount * 2.0;
            }
            else if (product == "Trauben")
            {
                return amount * 1.0;
            }
            else if (product == "Reis")
            {
                return amount * 5.0;
            }
            else
            {
                return amount * 16;
            }
        }

        public void PrintCurrentShoppingCart()
        {
            foreach (Produkt elem in ProduktList)
            {
                System.Console.WriteLine($"Produkt: {elem.ChoosenProduct} Jetziger Preis: {elem.PriceOfProduct} Anzahl: {elem.CountOfProducts}");
            }
        }

        public void DeleteProdukt()
        {
            System.Console.WriteLine("Was wollen sie löschen");
            string product = Console.ReadLine();

            System.Console.WriteLine("Wie viel davon wollen sie löschen");
            int amountToDelete = Convert.ToInt32(Console.ReadLine());

            Produkt found = ProduktList.FirstOrDefault(p => p.ChoosenProduct.Equals(product, StringComparison.OrdinalIgnoreCase));

            if (found == null)
            {
                Console.WriteLine("Dieses Produkt befindet sich nicht im Warenkorb!");
                return;
            }

            if (amountToDelete > found.CountOfProducts)
            {
                Console.WriteLine($"Sie haben nur {found.CountOfProducts} {found.ChoosenProduct} im Warenkorb!");
                return;
            }

            found.CountOfProducts -= amountToDelete;

            if (found.CountOfProducts == 0)
            {
                ProduktList.Remove(found);
            }

            TotalPriceOfWarenkorb -= PriceOfTheProduct(found.ChoosenProduct, amountToDelete);

            found.PriceOfProduct -= PriceOfTheProduct(found.ChoosenProduct, amountToDelete);

            Console.WriteLine($"Es wurden {amountToDelete} {product} gelöscht.");

            System.Console.WriteLine();
            System.Console.WriteLine("Jetziger Einkaufswagen");
            System.Console.WriteLine();
            PrintCurrentShoppingCart();
        }
    }
}