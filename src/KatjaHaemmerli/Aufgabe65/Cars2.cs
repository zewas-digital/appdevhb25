using System;
namespace Appdevhb25.KatjaHaemmerli.Aufgab65
{
    public class Car
    {
        // Felder
        public string Farbe ;
        public string Kennzeichen;
        public double Verbrauch;
        public int Distanz;
        // public int AlterKilometerstand;
        // public int NeuerKilometerstand;
        public int Kilometerstand;   

        // Standartkonstruktor ist immer verfügbar


        // Instanz Methode weil nicht static
        public void PrintCarAttribute()
        {
            System.Console.WriteLine(Farbe);
            System.Console.WriteLine(Kennzeichen);
            System.Console.WriteLine(Verbrauch);
        }
        public void Fahren()
        {
            // System.Console.WriteLine(AlterKilometerstand);
            System.Console.WriteLine(Kilometerstand);

            System.Console.WriteLine(Distanz);
            
            // NeuerKilometerstand = AlterKilometerstand + Distanz;
            Kilometerstand += Distanz;            
            // System.Console.WriteLine(NeuerKilometerstand);
            System.Console.WriteLine(Kilometerstand);
        }
    }
}