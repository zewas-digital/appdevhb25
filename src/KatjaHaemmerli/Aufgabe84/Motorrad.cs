namespace Appdevhb25.KatjaHaemmerli.Aufgabe84
{
    public class Motorrad : IGegenstand
    {
        public string Farbe {get; set;}
        public string Marke {get; set;}
        public string Seriennummer {get; set;}
        public string Kennzeichen {get; set;}
        public static double Verbrauch {get; set;}
        public static int AnzahlMotorraeder;

        public Motorrad(string model, string farbe, string seriennummer)
        {
            Marke = model; // beim erzeugen des Objekts model mitgegeben wird und initialisiert wird
            AnzahlMotorraeder++;
            Farbe = farbe;           
            AusgabeDerAttributte();
        }

        public void AusgabeDerAttributte()
        {
            System.Console.WriteLine($"Model: {Marke}");
            System.Console.WriteLine($"Farbe: {Farbe}");
        }

    }
}