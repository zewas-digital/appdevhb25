using System;

namespace Appdevhb25.SelinUlutuerk.Bonusaufgabe72
{
    class Fotoapparat
    {
        public string Modell;
        public string Hersteller;
        private double _megapixel;
        private double _bildschirmGroesse;

        // ? für null = kann beides mal null sein
        private Objektiv? _objektiv;
        private Speicherkarte? _karte;
        private int _counterPhoto = 0;

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

        public Fotoapparat(string hersteller, string modell, double megapixel, double bildschirmGroesse)
        {
            Hersteller = hersteller;
            Modell = modell;
            Megapixel = megapixel;
            BildschirmGroesse = bildschirmGroesse;
        }

        public void ObjektivTausch(Objektiv? objektiv)
        {
            _objektiv = objektiv;
        }
        public void SpeicherkarteTausch(Speicherkarte? karte)
        {
            _karte = karte;
        }


        public int FotosAufgenommen()
        {
            return _counterPhoto;
        }

        public double FreierSpeicher()
        {
            if (_karte != null)
            {
                return _karte.VerfuegbarerSpeicher;
            }
            else
            {
                return 0.0; // wenn keine Karte
            }
        }

        public void TakePhoto()
        {
            System.Console.WriteLine("Let's take a photo!\nReady? (Yes/No)");
            string? antwort = Console.ReadLine();

            while (antwort == "Yes")
            {
                if (_karte == null)
                {
                    System.Console.WriteLine("Keine Speicherkarte eingelegt!");
                    break;
                }

                double bedarf = 0.3 * Megapixel; // pro Bild

                System.Console.WriteLine("\n1\n2\n3...\nCHEESE!!!");
                Console.WriteLine("Do you want to take another one? (Yes/No)");

                _karte.VerfuegbarerSpeicher -= bedarf; // Speicher abzeiehen
                _counterPhoto++; // Counter erhöhen

                antwort = Console.ReadLine(); // neue Eingabe nötig
            }

            Console.WriteLine("\nOkay, no more photos.");
        }

        public void TakenPhotos()
        {
            if (_karte != null)
            {
                // Kamera übergibt automatisch ihren eigenen Zähler + Megapixel
                _karte.TakenPhotos(_counterPhoto, Megapixel);
            }
            else
            {
                Console.WriteLine("Keine Speicherkarte eingelegt!");
            }
        }
    }

    class Objektiv
    {
        private double _brennweite;

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

        public Objektiv(double brennweite)
        {
            Brennweite = brennweite;
        }
    }

    class Speicherkarte
    {
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

        public Speicherkarte(double verfuegbarerSpeicher)
        {
            VerfuegbarerSpeicher = verfuegbarerSpeicher;
        }

        private static double SpeicherProBildMB(double megapixel)
        {
            return 0.3 * megapixel;
        }

        public void TakenPhotos(int anzahlBilder, double megapixel)
        {
            double speicherProBild = SpeicherProBildMB(megapixel);

            Console.WriteLine($"\nEs sind noch {VerfuegbarerSpeicher:0.##} MB auf dieser Karte frei. ");
            Console.WriteLine($"Es wurden bereits {anzahlBilder} Bilder aufgenommen.");
            
        }
    }

    public class Intro
    {
        public static void Start()
        {
            Fotoapparat[] kameras = new Fotoapparat[2];

            kameras[0] = new Fotoapparat("Sony", "Alpha 7 IV", 28.0, 3.5);
            kameras[1] = new Fotoapparat("Nikon", "Z50", 16.0, 3.2);

            //einsetzten von Speicherkarte
            kameras[0].SpeicherkarteTausch(new Speicherkarte(1000));

            kameras[0].TakePhoto();
            kameras[0].TakenPhotos();


        }
    }
}