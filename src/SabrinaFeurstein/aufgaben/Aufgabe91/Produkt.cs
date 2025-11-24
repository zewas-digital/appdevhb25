namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe91
{
    // Festlegung bestimmter Werte eines Produktes (Nummer, Name und Preis)
    public class Produkt
    {
        public string Nummer { get; set; }
        public string Name { get; set; }
        public double Preis { get; set; }

        public Produkt(string nummer, string name, double preis)
        {
            Nummer = nummer;
            Name = name;
            Preis = preis;
        }
    }
}