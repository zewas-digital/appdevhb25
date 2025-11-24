namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe91
{
    // Die Menge eines bestimmten Produktes, die im Warenkorb landet
    public class WarenkorbProdukt
    {
        public Produkt Produkt { get; set; }
        public int Menge { get; set; }

        public WarenkorbProdukt(Produkt produkt, int menge)
        {
            Produkt = produkt;
            Menge = menge;
        }

        public override string ToString()
        {
            return $"{Produkt.Name} ({Menge}x) - {Produkt.Preis * Menge:F2} EUR";
        }
    }
}