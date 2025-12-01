using Appdevhb25.JulianMatt.Aufgabe25;

namespace Appdevhb25.JulianMatt.Aufgabe91
{
    public class Warenkorb
    {
        List<Produkt> ProduktInfo = new List<Produkt>();
        Dictionary<string, double> ProduktDict = new Dictionary<string, double>();

        public string NameOfTheOwnerOfWarenkorp;

        public double TotalPriceOfWarenkorb = 0;

        public void FillProductWithNeededInfo(string product)
        {
            if (ProduktInfo.Count == 0)
            {
                Produkt apple = new Produkt();
                apple.FillProduktUp("Äpfel", 1.50, 100, new List<string> { "Vitamin C", "Fiber" });

                Produkt banana = new Produkt();
                banana.FillProduktUp("Bananen", 2.0, 100, new List<string> { "Potassium", "Vitamin B6" });

                Produkt grapes = new Produkt();
                grapes.FillProduktUp("Trauben", 1.0, 100, new List<string> { "Vitamin K", "Antioxidants" });

                Produkt ricePack = new Produkt();
                ricePack.FillProduktUp("Reispackung", 5.0, 50, new List<string> { "Carbohydrates", "Protein" });

                ProduktInfo.Add(apple);
                ProduktInfo.Add(banana);
                ProduktInfo.Add(grapes);
                ProduktInfo.Add(ricePack);
            }
            else
            {
                System.Console.WriteLine("Dieses Produkt gibt es zwar nicht in unserem lager aber wir können gerne für sie das Produkt Bestellen\nWie viel Stück wollen sie Bestellen?");
                int amountToOrder = Convert.ToInt32(Console.ReadLine());
                
                System.Console.WriteLine("Wie viel Kostet das Stück?");
                double pricePerPiece = Convert.ToDouble(Console.ReadLine());

                System.Console.WriteLine("Was sind die Nährwärt stoffe des Produktes (Wenn sie keine mehr eingeben wollen drücken sie enter ohne das irgendwas im Feld steht)");
                List<string> nutritions = new List<string>();
                while (true)
                {
                    string? input = Console.ReadLine();
                    if(input == "")
                    {
                        break;
                    }
                    else
                    {
                        nutritions.Add(input);
                    }
                }

                Produkt newProduct = new Produkt();
                newProduct.FillProduktUp(product, pricePerPiece, amountToOrder, nutritions);
            }
            
        }

        public void FillWarenkorb()
        {
            string str = new string ('-', 50);

            System.Console.WriteLine(str);
            System.Console.WriteLine();
            System.Console.WriteLine("Wie ist der Name Des Aktuelen Kundens?");

            FillProductWithNeededInfo("");                                                                    

            NameOfTheOwnerOfWarenkorp = Console.ReadLine();

            string input = "ja";
            while (input != "nein")
            {
                    

                double priceOfChoosenGood = 0;
                System.Console.WriteLine($"Was wollen sie kaufen? \n\nZur Auswahl sind \nÄpfel = 1.50 \nBananen = 2.0 \nTrauben = 1.0 \nReispackung = 5.0");
                string? product = Console.ReadLine();

                System.Console.WriteLine($"Wie viel Stück {product} wollen sie Kaufen");
                int amount = Convert.ToInt32(Console.ReadLine());

                bool isHere = IsProductAlreadyHere(product, amount);

                if (isHere == false)
                {
                    priceOfChoosenGood = PriceOfTheProduct(product, amount);

                    TotalPriceOfWarenkorb += priceOfChoosenGood;

                    ProduktDict.Add(product, priceOfChoosenGood);
                }
                else
                {
                    ProduktDict[product] += PriceOfTheProduct(product, amount);
                }


                PrintCurrentShoppingCart(amount);

                System.Console.WriteLine($"{TotalPriceOfWarenkorb} Euro ist der momentare Gesamtpreis ihres Einkaufswagens");

                System.Console.WriteLine($"Wollen sie ein Weiteres Produkt Hinzufügen (Ja|Nein), fals sie ein Produkt löschen wollen schreiben sie delete");
                while (true)
                {
                    input = Console.ReadLine().ToLower();
                    if (input.ToLower() == "delete")
                    {
                        DeleteProdukt(amount);
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
            string prodKey = (product ?? "").Trim();
            if (string.IsNullOrEmpty(prodKey))
            {
                return false;
            } 

            if (!ProduktDict.TryGetValue(prodKey, out double currentTotalForProduct))
                return false;

            Produkt? found = ProduktInfo.FirstOrDefault(p => p.ChoosenProduct.Equals(prodKey, StringComparison.OrdinalIgnoreCase));
            if (found == null) return false;

            found.CountOfProducts += amount;
            double addPrice = PriceOfTheProduct(found.ChoosenProduct, amount);
            TotalPriceOfWarenkorb += addPrice;

            ProduktDict[prodKey] = currentTotalForProduct + addPrice;
            return true;
        }
        

        public double PriceOfTheProduct(string product, int amount)
        {
            Produkt? found = ProduktInfo.FirstOrDefault(p => p.ChoosenProduct.Equals(product, StringComparison.OrdinalIgnoreCase));
            while (true)
            {
                if (found == null)
                {
                    FillProductWithNeededInfo(product);
                }
                else
                {
                    return found.PriceOfProduct * amount;
                }
            }
            
        }

        public void PrintCurrentShoppingCart(int amount)
        {
            foreach (var elem in ProduktDict)
            {
                System.Console.WriteLine($"{amount}x Produkt: {elem.Key} Preis: {elem.Value/amount} = {elem.Value}");
            }
        }

        public void DeleteProdukt(int amount)
        {
            System.Console.WriteLine("Was wollen sie löschen");
            string? product = Console.ReadLine();

            System.Console.WriteLine("Wie viel davon wollen sie löschen");
            int amountToDelete = Convert.ToInt32(Console.ReadLine());

            Produkt? found = ProduktInfo.FirstOrDefault(p => p.ChoosenProduct.Equals(product, StringComparison.OrdinalIgnoreCase));

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
                ProduktInfo.Remove(found);
            }

            TotalPriceOfWarenkorb -= PriceOfTheProduct(found.ChoosenProduct, amountToDelete);

            found.PriceOfProduct -= PriceOfTheProduct(found.ChoosenProduct, amountToDelete);

            Console.WriteLine($"Es wurden {amountToDelete} {product} gelöscht.");

            System.Console.WriteLine();
            System.Console.WriteLine("Jetziger Einkaufswagen");
            System.Console.WriteLine();
            PrintCurrentShoppingCart(amount - amountToDelete);
        }
    }
}