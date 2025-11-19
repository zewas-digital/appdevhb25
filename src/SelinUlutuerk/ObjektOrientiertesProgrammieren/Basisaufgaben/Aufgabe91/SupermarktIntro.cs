using System;

namespace Appdevhb25.SelinUlutuerk.Aufgabe91
{
    public class SupermarktIntro
    {
        public static void Start()
        {
            var apfel = new Produkt("A001", "Apfel", 0.50);
            var milch = new Produkt("A002", "Milch", 1.59);
            var brot = new Produkt("B001", "Brot", 2.49);

            var warenkorb = new Warenkorb();
            var kasse = new Kasse();

            // Einkauf
            warenkorb.Hinzufuegen(apfel,4);
            warenkorb.Hinzufuegen(milch,2);
            warenkorb.Hinzufuegen(brot,1);

            warenkorb.Bearbeiten(apfel, 6);

            // Kunde bezahlt
            kasse.Bezahlen(warenkorb);
            kasse.PrintTagesumsatz();
            

        }
    }
}