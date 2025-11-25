namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe96
{
    public abstract class Figur
    {
        protected string Name { get; init; }
        protected string Elementtyp { get; init; }

        public Figur(string name)
        {
            Name = name;
            Elementtyp = "";
        }

        public abstract double UmfangBerechnen();
        public abstract double FlaecheninhaltBerechnen();
    }
}