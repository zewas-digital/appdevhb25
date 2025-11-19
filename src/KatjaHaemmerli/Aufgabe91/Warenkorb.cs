using System;
namespace Appdevhb25.KatjaHaemmerli.Aufgabe91
{
    public class Warenkorb
    {
        private List<Warenkorbitem> items = new List<Warenkorbitem>();
        // public double Gesamtpreis => items.Sum(el => el.Menge * el.Produkt.Preis); Andere Option für getGesamtPreis

        public Warenkorb()
        {

        }
        public double getGesamtPreis()
        {
            double summe = 0;
            foreach (Warenkorbitem item in items)
            {
                double temp = item.Menge * item.Produkt.Preis;
                summe += temp;
            }
            return summe;
        }
        public void ProduktHinzufuegen(Produkt produkt, int menge)
        {
            items.Add(new Warenkorbitem(produkt, menge));
            System.Console.WriteLine("EinProdukt wurde hinzugefügt");
        }

        public void ProduktEntfernen(Produkt produkt, int menge)
        {
            items.Remove(new Warenkorbitem(produkt, menge));
            System.Console.WriteLine("Ein Produkt wurde entfernt");
        }
        
    }
}
































