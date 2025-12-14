namespace Appdevhb25.NoahHois.ZooTeil3
{
    public class Gehege
    {
        public string Name { get; private set; }

        public Gehege(string name)
        {
            Name = name;
        }
        public List<Tier> _tier { get; private set; } = new List<Tier>();

        public void TierHinzufügen(Tier tier)
        {
            _tier.Add(tier);
        }
        public void TierEntfernen(Tier tier)
        {
            _tier.Remove(tier);
        }
    }
}