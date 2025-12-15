namespace Appdevhb25.KatjaHaemmerli.Aufgabe67
{    
    public class Artikel
    {
        // 1. Attribute ("Inhalt der Schachtel")
        public string Artikelname;
        public double Preis;
        public int Menge;

        // Konstruktoren
        public Artikel(string artikelname, int menge,double preis)
        {
            Artikelname = artikelname;
            Preis = preis;
            Menge = menge;
        }
    }
}