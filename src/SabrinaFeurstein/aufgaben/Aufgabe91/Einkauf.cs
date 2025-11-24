namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe91
{
    // In dieser Klasse geschieht der ganze Einkaufsvorgang
    public class Einkauf
    {
        public static void Start()
        {
            Kasse kasse = new Kasse();
            Warenkorb warenkorb = new Warenkorb();

            warenkorb.ProduktHinzufuegen(new Produkt("456", "Apfel", 0.99), 1);
            warenkorb.ProduktHinzufuegen(new Produkt("456", "Apfel", 0.99), 1);
            warenkorb.ProduktHinzufuegen(new Produkt("125", "Schokolade", 1.50), 1);
            warenkorb.ProduktHinzufuegen(new Produkt("721", "Chips", 1.99), 4);
            warenkorb.ProduktHinzufuegen(new Produkt("345", "Cola", 2.45), 5);

            warenkorb.ProduktLoeschen("cola");

            warenkorb.ProduktMengeAendern("schokolade", 3);

            kasse.Bezahlen(warenkorb);
        }
    }
}