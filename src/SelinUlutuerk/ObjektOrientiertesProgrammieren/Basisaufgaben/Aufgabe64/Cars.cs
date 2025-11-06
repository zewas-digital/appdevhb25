using System;

namespace Appdevhb25.SelinUlutuerk.Aufgabe64
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
        public void PrintColor()
        {
            System.Console.WriteLine(Farbe);
        }
    }
}