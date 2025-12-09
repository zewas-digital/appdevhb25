namespace Appdevhb25.SabrinaFeurstein.aufgaben.zoo.teil2
{
    public class Tier(string name, string gattung)
    {
        public string Name { get; private set; } = name;
        public string Gattung { get; private init; } = gattung;

        public override string ToString()
        {
            return $"{Name}, {Gattung}";
        }
    }
}