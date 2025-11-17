using System;

namespace Appdevhb25.OliverBedogg.aufgabe73
{

    public abstract class Hardware
    {
        public string Modell { get; init; } 
        // init: erlaubt das Setzen des Werts nur bei Initialisierung des Objekts
        // zum Sicherstellen, dass ein Feld nur einmalig befüllt werden darf
        public string Seriennummer { get; init; }

        public Hardware(string seriennummer, string modell)
        {
            Modell = modell;
            Seriennummer = seriennummer;
        }

        public override string ToString()
        {
            return Modell +", SN: "+ Seriennummer;
        }
    }
}