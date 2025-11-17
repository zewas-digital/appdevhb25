namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe73
{
    public class Objektiv : Hardware
    {
        private double _brennweite;

        public double Brennweite
        {
            get
            {
                return _brennweite;
            }
            set
            {
                _brennweite = value;
            }
        }

        public Objektiv(string seriennummer, string modell, double brennweite) : base(modell, seriennummer)
        {
            Brennweite = brennweite;
        }
         public override string ToString()
        {
            return base.ToString() + $"Brennweite: {Brennweite}";
        }
    }
}