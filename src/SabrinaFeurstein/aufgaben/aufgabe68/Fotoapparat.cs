namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe68
{
    public class Fotoapparat
    {
        private int _brennweiteMin;
        private int _brennweiteMax;
        private double _megapixel;
        public int BrennweiteMin
        {
            get
            {
                return _brennweiteMin;
            }
            set
            {
                if (value >= 7)
                    _brennweiteMin = value;
                else
                    Console.WriteLine("Brennweite kann nicht kürzer als 7mm sein!");
            }
        }
        public int BrennweiteMax
        {
            get
            {
                return _brennweiteMax;
            }
            set
            {
                if (value <= 2000)
                    _brennweiteMax = value;
                else
                    Console.WriteLine("Brennweite kann nicht länger als 2000mm sein!");
            }
        }
        public string Model;
        public string Hersteller;
        public double Megapixel
        {
            get
            {
                return _megapixel;
            }
            set
            {
                if (value > 0 && value <= 102)
                    _megapixel = value;
                else if (value < 0)
                    Console.WriteLine("Eine Kamera kann nicht nicht weniger als 0 Megapixel haben!");
                else
                    Console.WriteLine("Eine Kamera kann nicht derzeit nicht mehr als 102 Megapixel haben!");
            }
        }

        public Fotoapparat(int brennweiteMin, int brennweiteMax, string model, string hersteller, double megapixel)
        {
            BrennweiteMin = brennweiteMin;
            BrennweiteMax = brennweiteMax;
            Model = model;
            Hersteller = hersteller;
            Megapixel = megapixel;
        }

        public void TakePhoto()
        {
            Console.WriteLine($"\n\t\t<Foto>\nShot with {Hersteller} {Model}, {BrennweiteMin}mm - {BrennweiteMax}mm, {Megapixel}MP");
        }
    }
}