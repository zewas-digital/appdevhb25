using System;
using System.Globalization;
namespace Appdevhb25.SheilaMayJaro.Aufgabe67
{
    public class Inventory2
    {
        public static void Start()
        {
            System.Console.WriteLine("Aufgabe 67)");
            Console.OutputEncoding = System.Text.Encoding.Default;
            /* 
            Überarbeite deine Lösung für Aufgabe 59 so, dass die einzelnen Artikel und ihre Informationen in Form von Objekten in ein Array gespeichert werden. 
            Iteriere anschließend über dieses Array, um die Ausgabe der folgenden Werte zu erzeugen: 
                - teuerster Artikel
                - billigster Artikel
                - Durchschnittspreis aller Artikel
                - Gesamtwert aller Artikel und Mengen
            */
            string path = @"C:\Users\JASHE\Documents\DigitalCampus2025\appdevhb25\src\SheilaMayJaro\Aufgabe67VertiefteAufgabe\Inventory2input.txt";

            //Array mit dem Datentyp Article erstellt, wo die Inventur gespeichert wird
            Article[] articlelist = new Article[30];

            StreamReader reader = new StreamReader(path);
            using (reader)
            {
                //Schleife, damit es sich bei jeder Zeile wiederholt 
                int i = 0;
                while (reader.Peek() >= 0) //.Peek gibt -1 zurück, wenn kein lesendes Zeichen vorhanden ist
                {
                    //Zeile einlesen 
                    string? line = reader.ReadLine();
                    //Zeile in die Werte speichern: Artikel, Menge und Preis 
                    string[] valuesAsString = line.Split("\u2003", StringSplitOptions.RemoveEmptyEntries);

                    //Die einzelnen Werte in die entsprechenden Datentypen umwandeln
                    string articlename = valuesAsString[0];
                    int amount = Convert.ToInt32(valuesAsString[1]);
                    double price = Convert.ToDouble(valuesAsString[2]);

                    articlelist[i] = new Article(articlename, price, amount);
                    i++;
                }
            }
            Article mostExpensiveArticleInList = MostExpensiveArticle(articlelist);
            Article cheaepstArticleInList = CheapestArticle(articlelist);
            Article averagePriceOfList = AveragePriceOfInventory(articlelist);
            double totalValue = TotalValue(articlelist);
            System.Console.WriteLine(mostExpensiveArticleInList.Articlename);
            System.Console.WriteLine(cheaepstArticleInList.Articlename);
            System.Console.WriteLine(averagePriceOfList.Articlename);
            System.Console.WriteLine(totalValue.ToString("C2", CultureInfo.GetCultureInfo("de-AT")));
        }
        public static Article MostExpensiveArticle(Article[] inventory)
        {
            Article mostExpensiveArticle = inventory[0];

            for (int i = 1; i < inventory.Length; i++)
            {
                if (mostExpensiveArticle.Price < inventory[i].Price)
                {
                    mostExpensiveArticle = inventory[i];
                }
            }
            return mostExpensiveArticle;
        }
        public static Article CheapestArticle(Article[] inventory)
        {
            Article CheapestArticle = inventory[0];
            for (int i = 1; i < inventory.Length; i++)
            {
                if (CheapestArticle.Price > inventory[i].Price)
                {
                    CheapestArticle = inventory[i];
                }
            }
            return CheapestArticle;
        }
        public static Article AveragePriceOfInventory(Article[] inventory)
        {
            Article averagePriceOfInventory = inventory[0];

            for (int i = 1; i < inventory.Length; i++)
            {
                averagePriceOfInventory.Price += inventory[i].Price;
            }
            averagePriceOfInventory.Price = averagePriceOfInventory.Price / inventory.Length;
            return averagePriceOfInventory;
        }
        public static double TotalValue(Article[] inventory)
        {
            double totalValue = 0;

            for (int i = 0; i < inventory.Length; i++)
            {
                totalValue += inventory[i].Amount + inventory[i].Price;
            }
            return totalValue;
        }
    }
}