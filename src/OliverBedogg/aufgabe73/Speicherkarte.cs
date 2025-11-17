using System;

namespace Appdevhb25.OliverBedogg.aufgabe73
{

    public class Speicherkarte : Hardware
    {
        public int Speichergroesse { get; init; }

        private int _belegterSpeicher;
        public int BelegterSpeicher {
            get { return _belegterSpeicher; } 
            private set
            {
                if (value > Speichergroesse)
                {
                    Console.WriteLine("Nicht genug Speicherplatz verfügbar.");
                }
                else
                {
                    _belegterSpeicher = value;
                }
            }
        }

        public Speicherkarte(string seriennummer, string modell, int speichergroesse) : base(seriennummer, modell)
        {
            Speichergroesse = speichergroesse;
        }

        public void SpeichereDaten(int datenmenge)
        {
            BelegterSpeicher += datenmenge;
        }

        public override string ToString()
        {
            return base.ToString() +", Speichergröße: "+ Speichergroesse +" MB";
        }

    }
}