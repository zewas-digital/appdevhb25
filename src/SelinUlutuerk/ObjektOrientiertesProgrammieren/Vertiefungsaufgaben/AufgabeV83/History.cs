using System;

namespace Appdevhb25.SelinUlutuerk.AufgabeV83
{
    class History
    {
        public string? Name {get; set;}
        public DateTime Datum {get; set;}


        public History(string name, DateTime datum)
        {
            Name = name;
            Datum = datum;
        }

        public override string ToString()
        {
            return $"{Name} - {Datum:G}";
        }
    }
}