using System;

namespace Appdevhb25.SelinUlutuerk.Aufgabe71
{
    public class Auto: Fahrzeug
    {
        public int AnzahlDerTueren;
        public static int AnzahlDerProduziertenAutos = 0;

        public Auto(string farbe, int anzahlDerTueren) : base(farbe)
        {
            AnzahlDerTueren = anzahlDerTueren;
            AnzahlDerProduziertenAutos++;
        }

        public override void DruckeDatenblatt()
        {
            base.DruckeDatenblatt();
            System.Console.WriteLine("Anzahl der Türen: " + AnzahlDerTueren);
            System.Console.WriteLine(new string('-', 20));
        }

        public static void PrintAnzahlDerProduziertenAutos()
        {
            System.Console.WriteLine("Anzahl der produzierten Autos: " + AnzahlDerProduziertenAutos);
        }

        public void Fahren(double distanz)
        {
            double alterKilometerstand = Kilometerstand;
            double neuerKilometerstand = alterKilometerstand + distanz;

            Console.WriteLine($"Alter Kilometerstand: {alterKilometerstand} km");
            Console.WriteLine($"Gefahrene Distanz: {distanz} km");
            Console.WriteLine($"Neuer Kilometerstand: {neuerKilometerstand} km");
            System.Console.WriteLine();
            
            Kilometerstand = neuerKilometerstand;
        }
    }
}