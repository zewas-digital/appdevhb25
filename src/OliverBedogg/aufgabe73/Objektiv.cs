using System;

namespace Appdevhb25.OliverBedogg.aufgabe73
{

    public class Objektiv : Hardware
    {
        public int Brennweite { get; init; }

        public Objektiv(string seriennummer, string modell, int brennweite) : base(seriennummer, modell)
        {
            Brennweite = brennweite;
        }

        public override string ToString()
        {
            return base.ToString() +", Brennweite: "+ Brennweite;
        }

    }
}