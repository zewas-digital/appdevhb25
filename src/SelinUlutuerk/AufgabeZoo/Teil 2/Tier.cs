using System;

namespace Appdevhb25.SelinUlutuerk.AufgabeZoo.Teil1
{
    class Tier
    {
        public string Name {get; private set;}
        public string Gattung {get; private set;}


        public Tier(string name, string gattung)
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