using System;

namespace Appdevhb25.SelinUlutuerk.AufgabeV73
{

    class Hardware
    {
        private string? _modell;
        private string? _seriennummer;


        public string? Modell
        {
            get
            {
                return _modell;
            }
            set
            {
                _modell = value;
            }
        }
        public string? Seriennummer
        {
            get
            {
                return _seriennummer;
            }
            set
            {
                _seriennummer = value;
            }
        }

        public Hardware(string modell, string seriennummer)
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