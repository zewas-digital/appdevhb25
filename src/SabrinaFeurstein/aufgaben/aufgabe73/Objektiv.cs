namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe73
{
    public class Objektiv : Hardware
    {
        public int Brennweite { get; init; }

        public Objektiv(string modell, string seriennummer, int brennweite) : base(modell, seriennummer)
        {
            Brennweite = brennweite;
        }

        public override string ToString()
        {
            return $"{base.ToString}: {Brennweite} mm";
        }
    }
}