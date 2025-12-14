using System;

namespace Appdevhb25.SelinUlutuerk.AufgabeZoo.Teil1
{
    class Gehege
    {
        public string Name { get; private set; }
        public List<Tier> Tiere = new List<Tier>();

        public Gehege(string name)
        {
            Name = name;
        }

        public void HinzufuegenTier(Tier tier)
        {
            Tiere.Add(tier);
        }

        public void EntfernenTier(Tier tier)
        {
            Tiere.Remove(tier);
        }

        public override string ToString()
        {
            string result = $"│ ├── Gehege: {Name}\n";

            if (Tiere.Count == 0)
            {
                result += "│     ├── (leer)\n";
            }
            else
            {
                foreach (var t in Tiere)
                {
                    result += $"│     {t}\n";
                }
            }

            return result;
        }
    }
}