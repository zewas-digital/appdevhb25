namespace Appdevhb25.NoahHois.Aufgabe68
{
    public class Fotoapparat
    {
        // Reihenfolge Wichtig!!!!!
        // 1. alle Attriute
        public static int NumberOfCamerasProduced = 0;
        private int _minFocalLength;

        private int _maxFocalLength;

        private int _megapixels;

        // private Feld als Speicher


        // public Attribut ist ein Gatekeeper; der speichert nichts
        public int MinFocalLength
        {
            get
            {
                return _minFocalLength;
            }
            set
            {
                if (value > 0 && value < _maxFocalLength)
                {
                    _minFocalLength = value;
                }
                else
                {
                    Console.WriteLine("Wieso willst du noch mehr sehen?");
                }
            }
        }
        public int MaxFocalLength
        {
            get
            {
                return _maxFocalLength;
            }
            set
            {
                if (value > _minFocalLength)
                {
                    _maxFocalLength = value;
                }
                else
                {
                    Console.WriteLine("Niemand kann so genau Sachen betrachten.");
                }
            }
        }
        public string Model;
        public string Manufacturer;
        public int Megapixels
        {
            get
            {
                return _megapixels;
            }
            set
            {
                if (value > 10 || value > 50)
                {
                    _megapixels = value;
                }
                else
                {
                    Console.WriteLine("Du hast eine ungenaue Kamera oder du bist ein profi.");
                }
            }
        }

        // 2. danach alle Konstruktoren
        public Fotoapparat(int minFocalLength, int maxFocalLength, string model, string manufacturer, int megapixels)
        {
            MaxFocalLength = maxFocalLength;
            MinFocalLength = minFocalLength;
            Model = model;
            Manufacturer = manufacturer;
            Megapixels = megapixels;
        }

        public void Print()
        {
            Console.WriteLine("Minimale Brennweite: " + MinFocalLength);
            Console.WriteLine("Maximale Brennweite: " + MaxFocalLength);
            Console.WriteLine("Modell: " + Model);
            Console.WriteLine("Hersteller: " + Manufacturer);
            Console.WriteLine("Megapixel: " + Megapixels);
        }

    }
}