namespace Appdevhb25.SabrinaFeurstein.aufgaben.zoo.teil3
{
    public class Tier(string name, Gattung gattung)
    {
        public string Name { get; private set; } = name;
        public Gattung Gattung { get; private init; } = gattung;
        public Dictionary<Futter, double> Futterbedarf { get; private set; } = new Dictionary<Futter, double>();

        public void FutterHinzufuegen(Futter futter, double menge)
        {
            Futterbedarf.Add(futter, menge);
        }

        public override string ToString()
        {
            return $"{Name}, {Gattung}";
        }
    }
}