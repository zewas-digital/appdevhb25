using System;

namespace Appdevhb25.SelinUlutuerk.AufgabeZoo.Teil4
{
    class Pfleger
    {
        public string Name { get; private set; }
        private List<Gehege> _gehegeListe = new List<Gehege>();


        public Pfleger(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}