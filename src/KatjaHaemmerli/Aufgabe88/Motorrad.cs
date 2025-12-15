
namespace Appdevhb25.KatjaHaemmerli.Aufgabe88UML
{
    public class Motorcycle1 : Fahrzeug, IGegenstand
    {
        private double kilometerstand { get; set; }
        public string Seriennummer { get; set; }
        public string Marke { get; set; }
        public string Farbe{get; set;}

        public Motorcycle1(string marke, string farbe, double preis, string seriennummer)
            : base(farbe)
        {
            Marke = marke;
            Preis = preis;
            Seriennummer = seriennummer;
        }
        public void AusgabeDerAttribute()
        {
            System.Console.WriteLine(Farbe);
            System.Console.WriteLine(Seriennummer);
        }

        public override void Fahren(double distance)
        {
            kilometerstand += distance;
            System.Console.WriteLine($"Der Kilometerstand des Autos beträgt: {distance}");
        }

        public override void DruckeDatenblatt()
        {
            System.Console.WriteLine("Neues Datenblatt Motorad");
            System.Console.WriteLine($"Model: {Marke}");
            System.Console.WriteLine($"Farbe: {Farbe}");
            System.Console.WriteLine($"Preis: {Preis}");
        }

    }

}
