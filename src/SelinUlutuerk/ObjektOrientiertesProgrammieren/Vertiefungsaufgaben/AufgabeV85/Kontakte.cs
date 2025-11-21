using System;

namespace Appdevhb25.SelinUlutuerk.AufgabeV85
{
    class Kontakte
    {
        public string Nachname { get; set; }
        public string Ort { get; set; }
        public string Telefonnummer { get; set; }

        public Kontakte(string nachname, string ort, string telefonnummer)
        {
            Nachname = nachname;
            Ort = ort;
            Telefonnummer = telefonnummer;
        }

        public override string ToString()
        {
            return $"Nachname: {Nachname}, Ort: {Ort}, Telefonnummer: {Telefonnummer}";
        }
    }
}