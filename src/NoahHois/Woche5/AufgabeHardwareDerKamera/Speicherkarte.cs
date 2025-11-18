namespace Appdevhb25.NoahHois.Aufgabe73
{
    public class Speicherkarte : Hardware
    {
        public int Speichergroeße;

        public Speicherkarte(string seriennummer, string modell, int speichergroeße) : base(modell, seriennummer)
        {
            Speichergroeße = speichergroeße;
        }
        public override string ToString()
        {
            return $" {Modell}, SN: {Seriennummer}, Speichergröße: {Speichergroeße} MB";
        }
    }
}