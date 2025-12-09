namespace Appdevhb25.JonaSchnell.Aufgabe68
{
    public class Fotoapparat
    {
        private string _model = "";
        private string _hersteller = "";
        private double _brennweiteMin;
        private double _brennweiteMax;
        private double _megapixel;

        // Standard Konstruktor
        public Fotoapparat()
        {
            Hersteller = "Unbekannt";
            Model = "Unbekannt";
            BrennweiteMin = 18;
            BrennweiteMax = 55;
            Megapixel = 12;
        }

        // Konstruktor mit Basis-Informationen
        public Fotoapparat(string hersteller, string model)
        {
            Hersteller = hersteller;
            Model = model;
            BrennweiteMin = 18;
            BrennweiteMax = 55;
            Megapixel = 12;
        }

        // Konstruktor mit Megapixel
        public Fotoapparat(string hersteller, string model, double megapixel)
        {
            Hersteller = hersteller;
            Model = model;
            BrennweiteMin = 18;
            BrennweiteMax = 55;
            Megapixel = megapixel;
        }

        // Voller Konstruktor
        public Fotoapparat(string hersteller, string model, double brMin, double brMax, double megapixel)
        {
            Hersteller = hersteller;
            Model = model;
            BrennweiteMin = brMin;
            BrennweiteMax = brMax;
            Megapixel = megapixel;
        }

        public string Model
        {
            get { return _model; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Model darf nicht leer sein!");
                    return;
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
                    Console.WriteLine("Hersteller darf nicht leer sein!");
                    return;
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
                    Console.WriteLine("Minimale Brennweite muss größer als 0 sein!");
                    return;
                }
                _brennweiteMin = value;
            }
        }

        public double BrennweiteMax
        {
            get { return _brennweiteMax; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Maximale Brennweite muss größer als 0 sein!");
                    return;
                }
                if (value < _brennweiteMin)
                {
                    Console.WriteLine("Maximale Brennweite muss größer als minimale Brennweite sein!");
                    return;
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
                    Console.WriteLine("Megapixel muss größer als 0 sein!");
                    return;
                }
                _megapixel = value;
            }
        }


        public void TakePhoto()
        {
            if (_model == "" || _hersteller == "")
            {
                Console.WriteLine("Kamera ist nicht richtig konfiguriert!");
                return;
            }
            Console.WriteLine($"*KLICK* Ein Foto wurde mit der {Hersteller} {Model} gemacht!");
            Console.WriteLine($"(Brennweite: {BrennweiteMin}-{BrennweiteMax}mm, {Megapixel}MP)\n");
        }

        public void ZeigeDaten()
        {
            Console.WriteLine("=== Kamera Daten ===");
            Console.WriteLine($"Hersteller: {Hersteller}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Brennweite: {BrennweiteMin}-{BrennweiteMax}mm");
            Console.WriteLine($"Auflösung: {Megapixel} MP");
            Console.WriteLine("==================\n");
        }
    }
}