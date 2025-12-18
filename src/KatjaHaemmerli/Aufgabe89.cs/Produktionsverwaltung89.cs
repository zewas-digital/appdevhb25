using System;
using Appdevhb25.KatjaHaemmerli.Aufgabe91;
namespace Appdevhb25.KatjaHaemmerli.Aufgabe89
{
    public  class Produktonsverwaltung89
    {        
        public static void Start()
        {            
            List<string> produktListe = ProdukteHinzufuegen(); // ProdukteHinzufuegen() beinhaltet die Liste der Produkte vom return produkt;
        
            Console.WriteLine("Produktliste:");
            Console.WriteLine(new string ('-', 15));

            foreach (string produkt in produktListe)
            {
                Console.WriteLine($"- {produkt}");
            }
        
        }
        public static List<string> ProdukteHinzufuegen()
        {          
            List<string> produkte = new List<string>();
            produkte.Add("FanArtikel");
            produkte.Add("Schnabelkappe");
            produkte.Add("Handschuhe");

            return produkte;
        }
    }
}