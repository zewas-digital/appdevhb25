using System;

namespace Appdevhb25.SelinUlutuerk.AufgabeV73
{

    class Fotoapparat : Hardware
    {
        private Objektiv _objektiv;
        private Speicherkarte _karte;
        private int _anzahlFotos;
        private double _speicherProFoto = 5.0;

        public Objektiv Objektiv
        {
            get
            {
                return _objektiv;
            }
            set
            {
                _objektiv = value;
            }
        }

        public Speicherkarte Karte
        {
            get
            {
                return _karte;
            }
            set
            {
                _karte = value;
            }
        }

        public double AnzhalFotos
        {
            get
            {
                return _anzahlFotos;
            }
            set
            {
                _anzahlFotos = 0;
            }
        }

        public Fotoapparat(string seriennummer, string modell, Objektiv objektiv, Speicherkarte karte) : base(seriennummer, modell)
        {
            _objektiv = objektiv;
            _karte = karte;
        }

        public void WechselObjektiv(Objektiv objektiv)
        {
            _objektiv = objektiv;
        }
        public void WechselSpeichekarte(Speicherkarte karte)
        {
            _karte = karte;
        }

        public void Foto()
        {
            if (_karte == null)
            {
                Console.WriteLine("Keine Speicherkarte eingelegt!");
                return;
            }
            // Prüfen von Speicher
            if (_karte.VerfuegbarerSpeicher < _speicherProFoto)
            {
                Console.WriteLine("Nicht genug Speicherplatz auf der Karte!");
                return;
            }

            System.Console.WriteLine("Let's take a photo!\nReady? (Yes/No)");
            string? antwort = Console.ReadLine();

            while (antwort == "Yes")
            {
                if (_karte == null)
                {
                    System.Console.WriteLine("Keine Speicherkarte eingelegt!");
                    break;
                }

                System.Console.WriteLine("\n1\n2\n3...\nCHEESE!!!");
                Console.WriteLine("Do you want to take another one? (Yes/No)");

                _karte.VerfuegbarerSpeicher -= _speicherProFoto; // Speicher abziehen
                _anzahlFotos++; // Counter erhöhen

                // Überprüfung ob Speicher voll ist
                if (_karte.VerfuegbarerSpeicher < _speicherProFoto)
                {
                    Console.WriteLine("Speicher voll. Keine weiteren Fotos möglich.");
                    break;
                }

                antwort = Console.ReadLine(); // neue Eingabe nötig
            }
            Console.WriteLine("\nOkay, no more photos.");
        }

        public int AnzahlVerfuegbarenFotos()
        {
            return (int)(_karte.VerfuegbarerSpeicher / _speicherProFoto);
        }

        public override string ToString()
        {
            return base.ToString() +
                ", Aufgenommene Fotos: " + _anzahlFotos +
                "\n  Objektiv: " + _objektiv.ToString() +
                "\n  Speicherkarte: " + _karte.ToString();
        }
    }

    class Objektiv : Hardware
    {
        private double Brennweite { get; init; }

        // public double Brennweite
        // {
        //     get
        //     {
        //         return _brennweite;
        //     }
        //     set
        //     {
        //         _brennweite = value;
        //     }
        // }

        public Objektiv(string seriennummer, string modell, double brennweite) : base(seriennummer, modell)
        {
            Brennweite = brennweite;
        }
        public override string ToString()
        {
            return base.ToString() + ", Brennweite: " + Brennweite + "mm";
        }
    }

    class Speicherkarte : Hardware
    {
        private double _speicherGroesse;
        private double _verfuegbarerSpeicher;

        public double VerfuegbarerSpeicher
        {
            get
            {
                return _verfuegbarerSpeicher;
            }
            set
            {
                _verfuegbarerSpeicher = value;
            }
        }
        public double SpeicherGroesse
        {
            get
            {
                return _speicherGroesse;
            }
            set
            {
                _speicherGroesse = value;
            }
        }

        public Speicherkarte(string seriennummer, string modell, double speicherGroesse) : base(seriennummer, modell)
        {
            SpeicherGroesse = speicherGroesse;
            VerfuegbarerSpeicher = speicherGroesse;
        }
        public override string ToString()
        {
            return base.ToString() + ", Speichergröße: " + SpeicherGroesse + "MB, frei: " + VerfuegbarerSpeicher + "MB";
        }
    }
}

