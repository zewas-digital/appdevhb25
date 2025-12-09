using System;

namespace Appdevhb25.SelinUlutuerk.AufgabeZoo.Teil3
{
    class Tier
    {
        public string Name { get; private set; }
        public string Gattung { get; private set; }

        public Futter Futter { get; private set; }
        public decimal Menge { get; private set; }


        public Tier(string name, string gattung, Futter futter, decimal menge)
        {
            Name = name;
            Gattung = gattung;
            Futter = futter;
            Menge = menge;
        }

        public override string ToString()
        {
            return $"├── {Name}, {Gattung}";
        }
    }
}