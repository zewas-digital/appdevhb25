namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe72
{
    public class Speicherkarte
    {
        private double _speichergroesse;

        public double Speichergroesse 
        {
            get
            {
                return _speichergroesse;
            }
            set
            {
                if (value >= 0 && value <= 2000)
                    _speichergroesse = value;
                else
                    Console.WriteLine("Speichergröße kann nicht 0 GB sein!");
            }
        }

        public Speicherkarte(double speichergroesse)
        {
            Speichergroesse = speichergroesse;
        }
    }
}