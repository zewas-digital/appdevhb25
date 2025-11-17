namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe68
{
    public class Fotoapparat
    {
        private int _brennweiteMin;
        public int BrennweiteMin
        {
            get
            {
                return _brennweiteMin;
            }
            set
            {
                if (value >= 8)
                {
                    _brennweiteMin = value;
                }
                else
                {

                    Console.WriteLine("Das ist zu klein");
                }
            }
        }
        private int _brennweiteMax;
        public int BrennweiteMax
        {
            get
            {
                return _brennweiteMax;
            }
            set
            {
                if (value >= 300)
                {
                    _brennweiteMax = value;
                }
                else
                {

                    Console.WriteLine("Das ist zu groß");
                }
            }
        }
        private string _modell;
        public string Modell
        {
            get
            {
                return _modell;
            }
            set
            {
                if (value == "Lochkamera")
                {
                    _modell = value;
                }
                else
                {

                    Console.WriteLine("Dieses Modell gibt es nicht");
                }
            }
        }
        private string _hersteller;
        public string Hersteller
        {
            get
            {
                return _hersteller;
            }
            set
            {
                if (value == "Canon")
                {
                    _hersteller = value;
                }
                else
                {

                    Console.WriteLine("Diese Marke gibt es nicht");
                }
            }
        }
        private int _megapixel;
        public int Megapixel
        {
            get
            {
                return _megapixel;
            }
            set
            {
                if (value <= 20 && value > 0)
                {
                    _megapixel = value;
                }
                else
                {

                    Console.WriteLine("Das sind zu viel Megapixel");
                }
            }
        }

        public Fotoapparat(int brennweiteMin, int brennweiteMax, string modell, string hersteller, int megapixel)
        {
            BrennweiteMin = brennweiteMin;
            BrennweiteMax = brennweiteMax;
            Modell = modell;
            Hersteller = hersteller;
            Megapixel = megapixel;
        }

        public void Print()
        {
            Console.WriteLine("BrennweiteMin: " + BrennweiteMin);
            Console.WriteLine("BrennweiteMax: " + BrennweiteMax);
            Console.WriteLine("Modell: " + Modell);
            Console.WriteLine("Hersteller: " + Hersteller);
            Console.WriteLine("Megapixel: " + Megapixel);
        }

        public void TakePhoto()
        {
            Console.WriteLine();
            Console.WriteLine("Bitte Lächeln!");
        }
    }
}