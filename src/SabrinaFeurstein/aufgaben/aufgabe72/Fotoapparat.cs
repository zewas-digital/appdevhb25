namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe72
{
    public class Fotoapparat
    {
        public Objektiv Objektiv { get; set; }
        
        public Speicherkarte Speicherkarte { get; set; }

        private double _belegterSpeicher;
        public double BelegterSpeicher
        {
            get { return _belegterSpeicher; }
            private set
            {
                if (value > Speicherkarte.Speichergroesse)
                {
                    Console.WriteLine("Speicher voll!");
                }
                else
                {
                    _belegterSpeicher = value;
                }
            }
        }
        
        public string Model { get; init; }
        public string Hersteller { get; init; }

        private double _megapixel;
        public double Megapixel
        {
            get
            {
                return _megapixel;
            }
            set
            {
                if (value > 0 && value <= 200)
                    _megapixel = value;
                else if (value < 0)
                    Console.WriteLine("Eine Kamera kann nicht nicht weniger als 0 Megapixel haben!");
                else
                    Console.WriteLine("Eine Kamera kann derzeit nicht mehr als 200 Megapixel haben!");
            }
        }

        public int AufgenommeneFotos;

        public Fotoapparat(Objektiv objektiv, string model, string hersteller, double megapixel, Speicherkarte speicherkarte)
        {
            Objektiv = objektiv;
            Model = model;
            Hersteller = hersteller;
            Megapixel = megapixel;
            Speicherkarte = speicherkarte;
        }

        public void SpeicherBelegen(double datenmenge)
        {
            BelegterSpeicher += datenmenge;
        }

        public void TakePhoto()
        {
                Console.WriteLine($"\n\t\t<Foto>\nShot with {Hersteller} {Model}, {Objektiv.Brennweite}mm, {Megapixel}MP");
                AufgenommeneFotos++;
                SpeicherBelegen(0.3 * Megapixel);
        }
        public void Speicher()
        {
            Console.WriteLine($"\nKamera: {Hersteller} {Model}\nAnzahl der aufgenommenen Fotos: " + AufgenommeneFotos);
            Console.WriteLine($"{Speicherkarte.Speichergroesse - BelegterSpeicher * Math.Pow(10, -3):F3} GB von {Speicherkarte.Speichergroesse} GB frei");
        }
    }
}