using System;

namespace Appdevhb25.SelinUlutuerk.AufgabeZoo.Teil3
{
    class Gehege
    {
        public string Name { get; private set; }
        private List<Tier> _tiere = new List<Tier>();

        public Gehege(string name)
        {
            Name = name;
        }

        public void HinzufuegenTier(Tier tier)
        {
            _tiere.Add(tier);
        }

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
            string result = $"│   ├── Gehege: {Name}\n";

            if (_tiere.Count == 0)
            {
                result += "│       ├── (leer)\n";
            }
            else
            {
                foreach (var t in _tiere)
                {
                    result += $"│       {t}\n";
                }
            }

            return result;
        }
    }
}