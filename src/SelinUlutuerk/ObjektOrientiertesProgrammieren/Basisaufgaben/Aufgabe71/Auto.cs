using System;

namespace Appdevhb25.SelinUlutuerk.Aufgabe71
{
    public class Auto: Fahrzeug
    {
        public int AnzahlDerTueren;
        public static int AnzahlDerProduziertenAutos = 0;

        public Auto(string farbe, string kennzeichen, double kilometerstand, int anzahlDerTueren) : base(farbe, kennzeichen, kilometerstand)
        {
            AnzahlDerTueren = anzahlDerTueren;
            AnzahlDerProduziertenAutos++;
        }

        public override string ToString()
        {
            return $"{base.DruckeDatenblatt()}Anzahl der Türen: {AnzahlDerTueren}\n {new string('-', 20)}";
        }

        public static void PrintAnzahlDerProduziertenAutos()
        {
            System.Console.WriteLine("Anzahl der produzierten Autos: " + AnzahlDerProduziertenAutos);
        }

        
    }
}