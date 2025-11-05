using System;

namespace Appdevhb25.SelinUlutuerk.AufgabeV67
{
    class Artikel
    {
        // Felder
        public string ProduktName;
        public int Menge;
        public decimal Preis;


        // Standardkonstruktor ist immer verfügbar
        public Artikel()
        {

        }
        
        public Artikel(string produktName, int menge, decimal oreis)
        {
            ProduktName = produktName;
            Menge = menge;
            Preis = oreis;
        }
    }
}