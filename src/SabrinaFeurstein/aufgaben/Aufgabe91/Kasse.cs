namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe91
{
    // Kasse: Bezahlen aller Produkte in einem Warenkorb, Bezahlter Betrag wird zum Tagesumsatz der jeweilligen Kasse hinzugefügt
    public class Kasse
    {
        public double Tagesumsatz { get; set; }

        public void Bezahlen(Warenkorb warenkorb)
        {
            foreach (var produkt in warenkorb.Produkte)
            {
                Tagesumsatz += produkt.Produkt.Preis * produkt.Menge;
            }
            Console.WriteLine($"Zahlung erfolgt! Gesamtbetrag: {Tagesumsatz:F2} EUR");
        }
    }
}