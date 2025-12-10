namespace Appdevhb25.SabrinaFeurstein.aufgaben.zoo.teil2
{
    public class Gehege(string name)
    {
        public string Name { get; private set; } = name;
        public List<Tier> Tiere { get; private set; } = new List<Tier>();

        public void TierHinzufuegen(string name, string gattung)
        {
            Tiere.Add(new Tier(name, gattung));
        }
        public void TierEntfernen(string name, string gattung)
        {
            bool tierEntfernt = false;
            foreach (Tier tier in Tiere)
            {
                if (tier.Name.Contains(name, StringComparison.OrdinalIgnoreCase) && tier.Gattung.Contains(gattung, StringComparison.OrdinalIgnoreCase))
                {
                    Tiere.Remove(tier);
                    tierEntfernt = true;
                    break;
                }
            }
            if (!tierEntfernt)
                Console.WriteLine("Unbekanntes Tier. Tier wurde nicht entfernt!");
        }
        public override string ToString()
        {
            return Name;
        }
    }
}