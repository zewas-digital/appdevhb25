
using Appdevhb25.KatjaHaemmerli.Aufgabe88UML;

namespace Appdevhb25.KatjaHaemmerli.Aufgab88UML
{
    public class Car : IGegenstand
    {
        // Felder
        public string Farbe {get; set;}
        public string Marke {get; set;}
        public string Seriennummer {get; set;}
        public string Kennzeichen {get; set;}
        public static double Verbrauch {get; set;}
        

        // Standartkonstruktor wird nur generiert, wenn kein eigener erstellt wird.
       

        // selbst erstellter Konstruktor
        public Car(string farbe, string seriennummer) // ohne Rückgabewert weil Car selbst ist der Rückgabewert
        {
            Farbe = farbe;
            this.Seriennummer = seriennummer;
        }

        // Instanz Methode weil nicht static
        public void AusgabeDerAttribute()
        {
            System.Console.WriteLine(this.Farbe);
            System.Console.WriteLine(this.Seriennummer);
            System.Console.WriteLine(Verbrauch);
        }
    }
}