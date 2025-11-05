using System;

namespace Appdevhb25.SelinUlutuerk.Aufgabe68
{
    class Fotoapparat
    {
        private string _modell;
        private string _hersteller;
        private double _brennweite;
        private double _megapixel;
        private double _bildschirmGroesse;


        public string Hersteller
        {
            get
            {
                return _hersteller;
            }
            set
            {
                _hersteller = value;
            }
        }

        public string Modell
        {
            get
            {
                return _modell;
            }
            set
            {
                _modell = value;
            }
        }

        public double Megapixel
        {
            get
            {
                return _megapixel;
            }
            set
            {
                if (value > 0) _megapixel = value;
                else Console.WriteLine("Megapixel muss positiv sein!");
            }
        }

        public double Brennweite
        {
            get
            {
                return _brennweite;
            }
            set
            {
                _brennweite = value;
            }
        }

        public double BildschirmGroesse
        {
            get
            {
                return _bildschirmGroesse;
            }
            set
            {
                _bildschirmGroesse = value;
            }
        }

        public Fotoapparat(string hersteller, string modell, double megapixel, double brennweite, double bildschirmGroesse)
        {
            Hersteller = hersteller;
            Modell = modell;
            Megapixel = megapixel;
            Brennweite = brennweite;
            BildschirmGroesse = bildschirmGroesse;
        }

        public void TakePhoto()
        {
            System.Console.WriteLine("Let's take a photo!\nReady? (Yes/No)");
            string antwort = Console.ReadLine();

            while (antwort == "Yes")
            {
                System.Console.WriteLine("1\n2\n3...\nCHEESE!!!");
                Console.WriteLine("Do you want to take another one? (Yes/No)");
                antwort = Console.ReadLine(); // neue Eingabe nötig!
            }
            Console.WriteLine("Okay, no more photos.");
        }
    }
}