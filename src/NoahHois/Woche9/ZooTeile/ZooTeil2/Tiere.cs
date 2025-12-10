namespace Appdevhb25.NoahHois.ZooTeil2
{
    public class Tier
    {
        public string Name { get; private set; }
        public string Gattung { get; private init; }

        public Tier(string name, string gattung)
        {
            Name = name;
            Gattung = gattung;
        }
    }
}