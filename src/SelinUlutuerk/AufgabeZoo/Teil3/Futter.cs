using System;

namespace Appdevhb25.SelinUlutuerk.AufgabeZoo.Teil3
{
    class Futter
    {
        public string Name { get; private set; }
        public string Einheit { get; private set; }
        public decimal Einheitspreis { get; private set; }


        public Futter(string name, string einheit, decimal einheitspreis)
        {
            Name = name;
            Einheit = einheit;
            Einheitspreis = einheitspreis;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}