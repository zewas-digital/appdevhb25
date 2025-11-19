namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe73
{
    public class Speicherkarte : Hardware
    {
        private int _speichergröße;

        public int Speichergröße
        {
            get
            {
                return _speichergröße;
            }
            set
            {
                _speichergröße = value;
            }
        }

        public Speicherkarte(string seriennummer, string modell, int speichergroesse) : base(modell, seriennummer)
        {
            Speichergröße = speichergroesse;
        }

        public override string ToString()
        {
            return base.ToString() + $"Speichergröße: {Speichergröße}";
        }
    }
}