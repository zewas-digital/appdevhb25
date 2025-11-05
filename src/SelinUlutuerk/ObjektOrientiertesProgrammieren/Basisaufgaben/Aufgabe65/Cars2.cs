using System;

namespace Appdevhb25.SelinUlutuerk.Aufgabe65
{
    class Car
    {
        // Felder
        public string Farbe;

        public double Kilometerstand;

        public string Kennzeichen;

        public double Verbrauch;


        // Standardkonstruktor ist immer verfügbar
        public Car()
        {

        }

        // Instanz Methode, weil es nicht static ist
        public void PrintCar()
        {
            System.Console.WriteLine(Farbe);
            System.Console.WriteLine(Kilometerstand);
            System.Console.WriteLine(Kennzeichen);
            System.Console.WriteLine(Verbrauch);
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