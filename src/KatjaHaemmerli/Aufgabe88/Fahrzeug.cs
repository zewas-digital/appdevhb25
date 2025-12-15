namespace Appdevhb25.KatjaHaemmerli.Aufgabe88UML
{
    public abstract class Fahrzeug
    {
        public string Farbe;
        private double _preis;
        public double Preis
        {
            get
            {
                return _preis;
            }
            set
            {
                _preis = value;
            }
        }
        public Fahrzeug(string farbe)
        {
            Farbe = farbe; 
        }
       
        public virtual void Fahren(double distance)
        {
            System.Console.WriteLine("Fahrzeugausgabe2");
        }
        public virtual void DruckeDatenblatt()
        {
            System.Console.WriteLine("Datenblatt Vorlage");            
            System.Console.WriteLine($"Farbe: {Farbe}");
            System.Console.WriteLine($"Preis: {Preis}");
        }                   

    }
}