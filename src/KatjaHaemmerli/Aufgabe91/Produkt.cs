using System;
namespace Appdevhb25.KatjaHaemmerli.Aufgabe91
{
    public class Produkt
    {
        public string ProduktName;
        public decimal Preis;
        public Produkt(string produktname, decimal preis)
        {
            ProduktName = produktname;
            Preis = preis;
        }
    }
}