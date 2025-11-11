namespace Appdevhb25.JonaSchnell.Aufgabe68
{
    public class Kamera
    {
        private string _model = "";
        private string _hersteller = "";
        private double _brennweiteMin;
        private double _brennweiteMax;
        private double _megapixel;

        public Kamera()
        {
            _hersteller = "";
            _model = "";
            _brennweiteMin = 18;
            _brennweiteMax = 55;
            _megapixel = 12;
        }

        public Kamera(string hersteller, string model) : this()
        {
            _hersteller = hersteller;
            _model = model;
        }

        public Kamera(string hersteller, string model, double megapixel) : this(hersteller, model)
        {
            _megapixel = megapixel;
        }

        public Kamera(string hersteller, string model, double brMin, double brMax, double megapixel) : this(hersteller, model, megapixel)
        {
            _brennweiteMin = brMin;
            _brennweiteMax = brMax;
        }

        public string Model
        {
            get { return _model; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    System.Console.WriteLine();
                    Console.WriteLine("Model darf nicht leer sein.");
                    System.Console.WriteLine();
                }
                _model = value;
            }
        }

        public string Hersteller
        {
            get { return _hersteller; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    System.Console.WriteLine();
                    Console.WriteLine("Hersteller muss ausgewählt werden.");
                    System.Console.WriteLine();
                }
                _hersteller = value;
            }
        }

        public double BrennweiteMin
        {
            get { return _brennweiteMin; }
            set
            {
                if (value <= 0)
                {
                    System.Console.WriteLine();
                    Console.WriteLine("Brennweite muss größer als 0 sein!");
                    System.Console.WriteLine();
                }
                _brennweiteMin = value;
            }
        }

        public double BrennweiteMax
        {
            get { return _brennweiteMax; }
            set
            {
                if (value < BrennweiteMin)
                {
                    System.Console.WriteLine();
                    Console.WriteLine("Brennweite muss größer als 0 sein!");
                    System.Console.WriteLine();
                }
                _brennweiteMax = value;
            }
        }

        public double Megapixel
        {
            get { return _megapixel; }
            set
            {

                if (value <= 0)
                {
                    System.Console.WriteLine();
                    Console.WriteLine("Megapixel muss größer als 0 sein!");
                    System.Console.WriteLine();
                }
                _megapixel = value;
            }
        }


        public void TakePhoto()
        {
            System.Console.WriteLine();
            Console.WriteLine($"Das Foto wurde mit der  {Hersteller} {Model} gemacht.");
            System.Console.WriteLine();
        }
        public void Verkäufe()
        {
            System.Console.WriteLine();
            Console.WriteLine($"Kamera: {Hersteller} {Model}");
            Console.WriteLine($"Brennweite: {BrennweiteMin}-{BrennweiteMax} mm");
            Console.WriteLine($"Auflösung: {Megapixel} MP");
            Console.WriteLine();
        }
    }
}