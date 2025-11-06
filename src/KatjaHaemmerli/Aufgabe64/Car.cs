using System;
namespace Appdevhb25.KatjaHaemmerli.Aufgab64
{
    public class Car
    {
        // Felder
        public string Farbe ;
        public string Kennzeichen;
        public double Verbrauch;

        // Standartkonstruktor ist immer verfügbar


        // Instanz Methode weil nicht static
        public void PrintCarAttribute()
        {
            System.Console.WriteLine(Farbe);
            System.Console.WriteLine(Kennzeichen);
            System.Console.WriteLine(Verbrauch);
        }
    }
}