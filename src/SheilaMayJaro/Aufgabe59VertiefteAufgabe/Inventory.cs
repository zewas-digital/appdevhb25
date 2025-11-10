using System;
using System.Globalization;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Text;
namespace Appdevhb25.SheilaMayJaro.Aufgabe59
{
    public class Inventory
    {

        struct Price
        {
            public double Highest;
        }

        public static void Start()
        {
            Console.OutputEncoding = Encoding.Default;
            System.Console.WriteLine("Aufgabe 59) Inventur");
            /*
            Lies eine Artikelliste mit mindestens 30 Artikeln ein. 
            Die Artikelliste hat die Attribute "Name", "Menge" und "Preis". Berechne folgende Werte: 
            1. teuerster Artikel
            2. billigster Artikel
            3. Durchschnittspreis aller Artikel
            4. Gesamtwert aller Artikel und Mengen
            Schreibe die Werte in eine Datei. 
            */

            string filePathInput = @"C:\Users\JASHE\Documents\DigitalCampus2025\appdevhb25\src\SheilaMayJaro\Aufgabe59\InventoryInput.txt";
            string filePathOutput = @"C:\Users\JASHE\Documents\DigitalCampus2025\appdevhb25\src\SheilaMayJaro\Aufgabe59\InventoryOutput.txt";

            using (StreamReader inventoryFileReader = new StreamReader(filePathInput))
            {
                using (StreamWriter inventoryFileWriter = new StreamWriter(filePathOutput))
                {
                    InventoryPrices(inventoryFileReader, inventoryFileWriter);
                }
            }
        }
        public static void InventoryPrices(StreamReader inventoryFileReader, StreamWriter inventoryFileWriter)
        {
            string? inventoryFile = inventoryFileReader.ReadLine();
            double lowestPrice = 5;
            double highestPrice = 0;
            double sumOfPrices = 0;
            int counterOfInventory = 0;
            double totalValue = 0;
            string mostExpensiveItem = "";
            string cheapestItem = ""; 

            while (inventoryFile != null)
            {
                string[] priceAsStringArray = inventoryFile.Split("\u2003", StringSplitOptions.RemoveEmptyEntries);
                string priceAsString;
                if (priceAsStringArray.Length == 3)
                {
                    priceAsString = priceAsStringArray[2];
                }
                else
                {
                    priceAsString = priceAsStringArray[4];
                }
                double price = double.Parse(priceAsString, CultureInfo.GetCultureInfo("en"));
                if (price > highestPrice)
                {
                    highestPrice = price;
                    mostExpensiveItem = priceAsStringArray[0]; 

                }
                if (price < lowestPrice)
                {
                    lowestPrice = price;
                    cheapestItem = priceAsStringArray[0]; 
                }
                counterOfInventory++;
                string quantityAsString = string.Empty; 
                if (priceAsStringArray.Length == 3)
                {
                    quantityAsString = priceAsStringArray[1];
                }
                else
                {
                    quantityAsString = priceAsStringArray[2];
                }
                int quantity = Convert.ToInt32(quantityAsString, CultureInfo.GetCultureInfo("en"));
                sumOfPrices += price; //da man den Durchschnittspreis benötigt, ist die Menge nicht vonnöten
                totalValue += price * quantity; //Da man den Gesamtwer aller Artikel und deren Mengen wissen will, ist die Menge essenziell
                inventoryFile = inventoryFileReader.ReadLine();
            }
            // var result = "Trauben  15  1.80".Split("\u2003"); - Mischa
            inventoryFileWriter.WriteLine($"Der teuerste Artikel '{mostExpensiveItem}' kostet {highestPrice.ToString("C2", CultureInfo.GetCultureInfo("de-AT"))}");
            //Gibt ? zurück statt € Mit Console.OutputEncoding = Encoding.Default; gelöst - Mischa
            inventoryFileWriter.WriteLine($"Der billigste Artikel '{cheapestItem}' kostet {lowestPrice.ToString("C2", CultureInfo.GetCultureInfo("de-AT"))}");
            double averagePriceOfInventory = sumOfPrices / counterOfInventory;
            inventoryFileWriter.WriteLine($"Der Durchschnittspreis aller Artikel ist {averagePriceOfInventory.ToString("C2", CultureInfo.GetCultureInfo("de-AT"))}");
            inventoryFileWriter.WriteLine($"Der Gesamtwert aller Artikel und Mengen ist {totalValue.ToString("C2", CultureInfo.GetCultureInfo("de-AT"))}");
        }
    }
}