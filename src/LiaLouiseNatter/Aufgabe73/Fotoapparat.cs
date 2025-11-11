namespace Appdevhb25.LiaLouiseNatter.Aufgabe73
{
    public class Fotoapparat : Hardware
    {
        public int AnzahlFotos;
        private double AnzahlUebrigeFotos;
        public Objektiv Objektiv;
        public Speicherkarte Speicherkarte;

        private float _megapixel;
        public float Megapixel
        {
            get
            {
                return _megapixel;
            }
            set
            {
                if (value < 0.01 || value > 1000)
                {
                    System.Console.WriteLine("Minimale Megapixel: 0,1MP und Maximale Megapixel: 1000MP");
                }
                else
                {
                    _megapixel = value;
                }
            }
        }

        public Fotoapparat(string modell, string seriennumer) : base(modell, seriennumer)
        {
        }

        public void takePhoto()
        {
            AnzahlFotos++;
            Speicherkarte.SpeicherkartenPLatz -= 5;
        }

        public double AnzahlVerfuegbarerFotos()
        {
            AnzahlUebrigeFotos = Speicherkarte.SpeicherkartenPLatz / 5;
            Math.Round(AnzahlUebrigeFotos, 0);
            return AnzahlUebrigeFotos;
        }

        public void WechsleObjektiv(Objektiv objektivKamera)
        {
            Objektiv = objektivKamera;
        }
        public void WechsleSpeicherkarte(Speicherkarte speicherkarte)
        {
            Speicherkarte = speicherkarte;
        }
       
    }
}


























































































