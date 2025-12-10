using System;

namespace Appdevhb25.JonaSchnell.Aufgabe70
{
    public class Auto: Fahrzeug
    {
        public int doors;
        public static int carsMade = 0;

        public Auto(string colour, int doors) : base(colour)
        {
            this.doors = doors;
            carsMade++;
        }

        public override void DruckeDatenblatt()
        {
            base.DruckeDatenblatt();
            System.Console.WriteLine("Anzahl der Türen: " + doors);
            System.Console.WriteLine(new string('-', 20));
        }

        public static void PrintAnzahlDerProduziertenAutos()
        {
            System.Console.WriteLine("Anzahl der produzierten Autos: " + carsMade);
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