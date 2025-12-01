using System.Buffers.Binary;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace Appdevhb25.JonaSchnell.Aufgabe91
{
    public class Aufgabe91
    {
        public static void Start()
        {

        }
    }
    public class Warenkorb
    {
        public static void Produkte()
        {
            var price = new Random();
            Dictionary<string, double> productAndPrice = new Dictionary<string, double>();
            System.Console.WriteLine("Was packst du in den Warenkorb? Wenn du zur Kassa gehen willst drücke enter. Wenn du etwas entfernen willst, drücke Minus.");
            double bill = 0;
            while (true)
            {
                int i = 1;
                string inputProducts = Console.ReadLine();
                if (inputProducts != "")
                {
                    double priceForDictionary = price.Next(20, 1000) / 100.0;

                    foreach (char numberChecker in inputProducts)
                    {
                        if (numberChecker >= 48 && numberChecker <= 57)
                        {
                            i = numberChecker - 48;
                        }
                    }
                    System.Console.WriteLine("Price: " + priceForDictionary);
                    System.Console.WriteLine("Bill: " + bill);
                    bill = bill + priceForDictionary;
                    productAndPrice.Add(inputProducts, priceForDictionary * i);
                }
                else if (inputProducts == "")
                {
                    System.Console.WriteLine("Bitte schreib das Wort, das du entfernen willst.");
                    string delete = Console.ReadLine();
                    if (productAndPrice.Remove(delete))
                    {
                        System.Console.WriteLine("Das Produkt " + delete + " wurde entfernt.");
                    }
                    else
                    {
                        System.Console.WriteLine("Das Produkt existiert nicht.");
                    }
                }

                else
                {

                    foreach (var products in productAndPrice)
                    {
                        System.Console.WriteLine(products.Key + " " + products.Value + "€");
                    }
                    System.Console.WriteLine("Es wurden " + productAndPrice.Count + " Produkte verkauft. Und du musst " + bill + "€ bezahlen.");
                    break;
                }

            }
        }
    }
}
