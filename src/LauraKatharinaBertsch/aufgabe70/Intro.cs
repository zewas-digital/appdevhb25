namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe70
{
    public class Intro
    {
        public static void Start()
        {
            Auto auto1 = new Auto(5);
            auto1.Fahren(1);
            auto1.DruckeDatenblatt();
            auto1.PrintAnzahlDerProduziertenAutos();


            Console.WriteLine();

            Motorrad motorrad1 = new Motorrad(50, 10000);
            motorrad1.DruckeDatenblatt();
            Console.WriteLine("Der durchschnittliche Umsatz: " + Motorrad.BerechneDurschnittsumsatz());

            Console.WriteLine();

            Motorrad motorrad2 = new Motorrad(50, 20000);
            motorrad2.DruckeDatenblatt();
            Console.WriteLine("Der durchschnittliche Umsatz: " + Motorrad.BerechneDurschnittsumsatz());

            Console.WriteLine();

            Fahrzeuge.PrintAnzahlDerProduziertenFahrzeuge();
        }
    }
}