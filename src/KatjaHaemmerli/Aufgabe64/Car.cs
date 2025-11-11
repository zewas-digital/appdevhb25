namespace Appdevhb25.KatjaHaemmerli.Aufgab64
{
    public class Car
    {
        // Felder
        public string Farbe;
        public string Kennzeichen;
        public static double Verbrauch;
        private int seriennummer;

        // Standartkonstruktor wird nur generiert, wenn kein eigener erstellt wird.
       

        // selbst erstellter Konstruktor
        public Car(string farbe, int seriennummer) // ohne Rückgabewert weil Car selbst ist der Rückgabewert
        {
            Farbe = farbe;
            this.seriennummer = seriennummer;
        }

        // Instanz Methode weil nicht static
        public void PrintCarAttribute()
        {
            System.Console.WriteLine(this.Farbe);
            System.Console.WriteLine(this.Kennzeichen);
            System.Console.WriteLine(Verbrauch);
        }
    }
}