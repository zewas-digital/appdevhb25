using System;

namespace Appdevhb25.SelinUlutuerk.AufgabeZoo.Teil1
{
    class Tier
    {
        public string Name {get; private set;}
        public enum Gattungen
        {
            Kuh,
            Storch,
            Eisbaer
        }

        public Gattungen Gattung {get; private set;}


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