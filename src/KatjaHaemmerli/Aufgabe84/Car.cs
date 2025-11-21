using Appdevhb25.KatjaHaemmerli.Aufgabe84;

namespace Appdevhb25.KatjaHaemmerli.Aufgab84
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
        public void AusgabeDerAttributte()
        {
            System.Console.WriteLine(this.Farbe);
            System.Console.WriteLine(this.Kennzeichen);
            System.Console.WriteLine(Verbrauch);
        }
    }
}