namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe73
{
    public class Speicherkarte : Hardware
    {
        public double Speichergroesse { get; init; }

        public Speicherkarte(string modell, string seriennummer, double speichergroesse) : base(modell, seriennummer)
        {
            Speichergroesse = speichergroesse;
        }

        public override string ToString()
        {
            return $"{base.ToString}: {Speichergroesse} MB";
        }
    }
}