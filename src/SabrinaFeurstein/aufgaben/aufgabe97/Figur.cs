namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe97
{
    public abstract class Figur
    {
        protected string Name { get; init; }
        protected string Elementtyp { get; init; }
        protected double Faktor { get; set; }

        public Figur(string name, string elementtyp)
        {
            Name = name;
            Elementtyp = elementtyp;
            Faktor = 1;
        }

        public abstract double UmfangBerechnen();
        public abstract double FlaecheninhaltBerechnen();
    }
}