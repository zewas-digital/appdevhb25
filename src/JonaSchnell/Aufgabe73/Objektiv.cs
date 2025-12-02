using System;

namespace Appdevhb25.JonaSchnell.Aufgabe73
{
    public class Objektiv
    {
        public string Seriennummer { get; }
        public string Name { get; }
        public int MaxBrennweite { get; }

        public Objektiv(string seriennummer, string name, int maxBrennweite)
        {
            Seriennummer = seriennummer;
            Name = name;
            MaxBrennweite = maxBrennweite;
        }

        public override string ToString()
        {
            return $"{Name} ({MaxBrennweite}mm)";
        }
    }
}