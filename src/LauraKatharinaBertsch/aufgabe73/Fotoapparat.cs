namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe73
{
    public class Fotoapparat : Hardware
    {
        private int _anzahlFotos;
        public Objektiv objektiv;
        public Speicherkarte speicherkarte;

        public int AnzahlFotos
        {
            get
            {
                return _anzahlFotos;
            }
            private set
            {
                _anzahlFotos = value;
            }
        }

        public Fotoapparat(string modell, string seriennummer) : base(modell, seriennummer)
        {

        }

        public void Foto()
        {
            speicherkarte.Speichergröße = speicherkarte.Speichergröße - 5;
            _anzahlFotos = _anzahlFotos + 1;
        }
        public int AnzahlVerfuegbareFotos()
        {
            int verfügbareFotos = speicherkarte.Speichergröße / 5;
            return verfügbareFotos;
        }
        public void WechsleObjektiv(Objektiv objektivNeu)
        {
            objektiv = objektivNeu;
        }
        public void WechsleSpeicherkarte(Speicherkarte speicherkarteNeu)
        {
            speicherkarte = speicherkarteNeu;
        }
    }
}