using System;

namespace Appdevhb25.SelinUlutuerk.AufgabeZoo.Teil3
{
    class Tier
    {
        public string Name { get; private set; }

        // Enum für Gattungen
        public enum Gattungen
        {
            Kuh,
            Storch,
            Eisbaer
        }

        public Gattungen Gattung { get; private set; }
        
        // Alte Eigenschaften des Futterbedarfes
        // public Futter Futter { get; private set; }
        // public decimal Menge { get; private set; }

        // neues Futterbedarfsdictionary
        public Dictionary<Futter, decimal> Futterbedarf = new Dictionary<Futter, decimal>();

        public Tier(string name, Gattungen gattung)
        {
            Name = name;
            Gattung = gattung;
        }

        public override string ToString()
        {
            return $"├── {Name}, {Gattung}";
        }
    }
}