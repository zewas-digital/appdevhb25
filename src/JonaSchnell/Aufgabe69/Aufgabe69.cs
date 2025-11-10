namespace Appdevhb25.JonaSchnell.Aufgabe69
{
    public class Motorrad
    {
        private string _kennzeichen = "";
        private string _farbe = "";
        private double _kilometerstand;
        private double _leistung;
        private double _kaufpreis;


        public Motorrad()
        {
            _farbe = "Blau";
            _kennzeichen = "BZ35JP";
            _kilometerstand = 180;
            _leistung = 150;
            _kaufpreis = 12000;
        }

        public Motorrad(string farbe, string kennzeichen) : this()
        {
            _farbe = farbe;
            _kennzeichen = kennzeichen;
        }

        public Motorrad(string hersteller, string model, double kaufpreis) : this(hersteller, model)
        {
            _kaufpreis = kaufpreis;
        }

        public Motorrad(string hersteller, string model, double kilometerstand, double leistung, double megapixel) : this(hersteller, model, megapixel)
        {
            _kilometerstand = kilometerstand;
            _leistung = leistung;
        }

        public string Kennzeichen
        {
            get { return _kennzeichen; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    System.Console.WriteLine();
                    Console.WriteLine("Kennzeichen darf nicht leer sein.");
                    System.Console.WriteLine();
                }
                _kennzeichen = value;
            }
        }

        public string Farbe
        {
            get { return _farbe; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    System.Console.WriteLine();
                    Console.WriteLine("Farbe muss ausgewählt werden.");
                    System.Console.WriteLine();
                }
                _farbe = value;
            }
        }

        public double Kilometerstand
        {
            get { return _kilometerstand; }
            set
            {
                if (value <= 0)
                {
                    System.Console.WriteLine();
                    Console.WriteLine("Kilometerstand muss 0 sein!");
                    System.Console.WriteLine();
                }
                _kilometerstand = value;
            }
        }

        public double Leistung
        {
            get { return _leistung; }
            set
            {
                if (value <= 150)
                {
                    System.Console.WriteLine();
                    Console.WriteLine("Leistung muss 150 sein!");
                    System.Console.WriteLine();
                }
                _leistung = value;
            }
        }

        public double Kaufpreis
        {
            get { return _kaufpreis; }
            set
            {

                if (value <= 6000)
                {
                    System.Console.WriteLine();
                    Console.WriteLine("Kaufpreis muss mindestens 6000 sein!");
                    System.Console.WriteLine();
                }
                _kaufpreis = value;
            }
        }

        public void Verkäufe()
        {
            Console.WriteLine();
            Console.WriteLine($"Farbe: {Farbe}");
            Console.WriteLine($"Kennzeichen {Kennzeichen}");
            Console.WriteLine($"Kilometerstand: {Kilometerstand} km");
            Console.WriteLine($"Leistung: {Leistung} PS");
            Console.WriteLine($"Preis: {Kaufpreis} €");
            Console.WriteLine();
        }
    }
}