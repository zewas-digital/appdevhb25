namespace Appdevhb25.KatjaHaemmerli.Aufgabe84
{
    public class Motorcycle : IGegenstand
    {
        public string Farbe {get; set;}
        public string Marke {get; set;}
        public string Seriennummer {get; set;}
        public string Kennzeichen {get; set;}
        public static double Verbrauch {get; set;}
        public static int AnzahlMotorraeder;

        public Motorcycle(string model, string farbe, string seriennummer)
        {
            Marke = model; // beim erzeugen des Objekts model mitgegeben wird und initialisiert wird
            AnzahlMotorraeder++;
            Farbe = farbe;           
            AusgabeDerAttribute();
        }

        public void AusgabeDerAttribute()
        {
            System.Console.WriteLine($"Model: {Marke}");
            System.Console.WriteLine($"Farbe: {Farbe}");
        }

    }
}