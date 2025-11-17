using System;

namespace Appdevhb25.SelinUlutuerk.AufgabeV73
{

    class Hardware
    {
        public string? Modell { get; init; }
        private string? Seriennummer { get; init; }

        // init sorgt dafür das man es nur einmal befüllen kann

        // public string? Modell
        // {
        //     get
        //     {
        //         return _modell;
        //     }
        //     set
        //     {
        //         _modell = value;
        //     }
        // }

        // public string? Seriennummer
        // {
        //     get
        //     {
        //         return _seriennummer;
        //     }
        //     set
        //     {
        //         _seriennummer = value;
        //     }
        // }

        public Hardware(string seriennummer, string modell)
        {
            Modell = modell;
            Seriennummer = seriennummer;
        }

        public override string ToString()
        {
            return "Modell: " + Modell + ", Seriennummer: " + Seriennummer;
        }
    }
}