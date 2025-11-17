namespace Appdevhb25.NoahHois.Aufgabe73
{
    public class Objektiv : Hardware
    {
        public double Brennweite;

        public Objektiv(string seriennummer, string modell, double brennweite) : base(modell, seriennummer)
        {
            Brennweite = brennweite;
        }
        public override string ToString()
        {
            return $" {Modell}, SN: {Seriennummer}, Brennweite: {Brennweite}";

        }
    }
}