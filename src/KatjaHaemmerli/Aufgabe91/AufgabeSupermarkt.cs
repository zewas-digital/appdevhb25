using System;
using System.Security.Cryptography.X509Certificates;
namespace Appdevhb25.KatjaHaemmerli.Aufgabe91
{
    public class AufgabeSupermarkt
    {
        public static void Start()
        {
            Produkt banane = new Produkt("Bananen", 2.49);
            Produkt birne = new Produkt("Birne", 0.89);
            Produkt pflaume = new Produkt("Pflaume", 4);

            List<Produkt> sortiment = new List<Produkt>();

            // Kunde legt eines der Produkte aus dem Sortiment in seinen Warenkorb
            sortiment.Add(banane);
            sortiment.Add(birne);
            sortiment.Add(pflaume);

            Warenkorb warenkorb = new Warenkorb();
            Warenkorb warenkorb2 = new Warenkorb();

            Kasse kasse = new Kasse();
            Kasse kasse2 = new Kasse();

            warenkorb.ProduktHinzufuegen(sortiment[0], 3); // Banane wird hinzugefügt
            warenkorb.ProduktEntfernen(banane, 1);
            
            kasse.WarenkorbAbrechnen(warenkorb);
            kasse2.WarenkorbAbrechnen(warenkorb2);

            double summe1 = kasse.GesamtpreisBerechnen();
            double summe2 = kasse2.GesamtpreisBerechnen();

            System.Console.WriteLine($"Der Tagesumsatz von Kasse1 beträgt: {summe1}");
            System.Console.WriteLine($"Der Tagesumsatz von Kasse2 beträgt: {summe2}");
        }

    }
}