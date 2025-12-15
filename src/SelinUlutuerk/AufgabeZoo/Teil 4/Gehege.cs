using System;

namespace Appdevhb25.SelinUlutuerk.AufgabeZoo.Teil4
{
    class Gehege
    {
        public string Name { get; private set; }
        // nur set weil Pfleger sonst null bleibt
        public Pfleger? Pfleger { get; set; }
        private List<Tier> _tiere = new List<Tier>();

        public Gehege(string name)
        {
            Name = name;
        }

        // Hinzufügen der Tiere
        public void HinzufuegenTier(Tier tier)
        {
            _tiere.Add(tier);
        }

        // küzere Schreibweise:
        // public void HinzufuegenTier(Tier tier) => _tiere.Add(tier);

        // Entfernen der Tiere
        public void EntfernenTier(Tier tier)
        {
            _tiere.Remove(tier);
        }

        // Tiere mit Methode in anderen Methoden verfügbar machen
        public List<Tier> HoleTiere()
        {
            return _tiere;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}