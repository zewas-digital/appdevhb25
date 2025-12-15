
namespace Appdevhb25.KatjaHaemmerli.Aufgabe70
{
    public class Motorrad : Fahrzeug
    {
        double kilometerstand;
        private string _model;
        public string Model
        {
            get
            {
                return _model;
            }

            private set // privat, weil von Aussen soll das Model nicht verändert werden dürfen.
            {
                _model = value;
            }

        }

        // Konstuktor
        public Motorrad(string model, string farbe, double preis) : base(farbe)
        {
            Model = model;
            Farbe = farbe;
            Preis = preis;
        }

        public override void Fahren(double distance)
        {
            kilometerstand += distance;
            System.Console.WriteLine($"Der Kilometerstand des Autos beträgt: {distance}");
        }

        public override void DruckeDatenblatt()
        {
            System.Console.WriteLine("Neues Datenblatt Motorad");
            System.Console.WriteLine($"Model: {Model}");
            System.Console.WriteLine($"Farbe: {Farbe}");
            System.Console.WriteLine($"Preis: {Preis}");
        }

    }

}
