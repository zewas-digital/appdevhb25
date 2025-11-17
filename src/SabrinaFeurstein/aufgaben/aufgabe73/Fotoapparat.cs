namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe73
{
    public class Fotoapparat : Hardware
    {
        private Objektiv? _objektiv { get; set; }
        public Objektiv? Objektiv
        {
            get { return _objektiv; }
        }

        public Speicherkarte? _speicherkarte { get; set; }
        public Speicherkarte? Speicherkarte
        {
            get { return _speicherkarte; }
        }

         private double _belegterSpeicher;
        public double BelegterSpeicher
        {
            get { return _belegterSpeicher; }
            private set
            {
                if (value > Speicherkarte!.Speichergroesse)
                {
                    Console.WriteLine("Speicher voll!");
                }
                else
                {
                    _belegterSpeicher = value;
                }
            }
        }

        public int AnzahlFotos { get; private set; }

        public Fotoapparat(string modell, string seriennummer) : base(modell, seriennummer)
        {
            AnzahlFotos = 0;
        }

        public void SpeicherBelegen(double datenmenge)
        {
            BelegterSpeicher += datenmenge;
        }

        public void Foto()
        {
            if (_objektiv == null)
            {
                Console.WriteLine("Kein Objektiv montiert! Foto nicht möglich.");
                return;
            }

            if (_speicherkarte == null)
            {
                Console.WriteLine("Keine Speicherkarte eingelegt! Foto nicht möglich.");
                return;
            }

            if (_speicherkarte != null && _objektiv != null)
            {
                Console.WriteLine($"\n\t\t<Foto>\nShot with {Modell} {Seriennummer}");
                AnzahlFotos++;
                SpeicherBelegen(0.005);
            }
        }
        public void AnzahlVerfuegbarerFotos()
        {
            if (_speicherkarte == null)
            {
                Console.WriteLine("Keine Speicherkarte eingelegt!");
            }
            else
                Console.WriteLine($"So viele Fotos haben noch Platz auf der Speicherkarte: {(Speicherkarte!.Speichergroesse - BelegterSpeicher) / 0.005}");
        }

        public void WechsleSpeicherkarte(Speicherkarte speicherkarte)
        {
            _speicherkarte = speicherkarte;
        }
        public void WechsleObjektiv(Objektiv objektiv)
        {
            _objektiv = objektiv;
        }

        public void SpeicherAnzeigen()
        {
            Console.WriteLine($"Speicher von {Modell} {Seriennummer}: {Speicherkarte!.Speichergroesse} GB");
        }
        public void ObjektivAnzeigen()
        {
            Console.WriteLine($"Objektiv von {Modell} {Seriennummer}: {Objektiv!.Brennweite} mm");
        }
    }
}