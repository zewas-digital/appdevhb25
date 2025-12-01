using System;
using System.Security.Cryptography.X509Certificates;
namespace Appdevhb25.KatjaHaemmerli.Aufgabe91
{
    public class Warenkorbitem
    {
        public Produkt EinzelProdukt;
        public int Menge;
        /* in dieser Klasse: // anzahlProdukt Menge in eine referenztabelle -> 
        // Warenkorbitem Klasse (Warenkorb zeigt auf Warenkorbitem und Warenkorbitem zeigt auf Produkt)*/
        public Warenkorbitem(Produkt produkt, int menge)
        {
            EinzelProdukt = produkt;
            Menge = menge;

        }        


    }
}