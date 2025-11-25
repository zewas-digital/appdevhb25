using System;

namespace Appdevhb25.SelinUlutuerk.Aufgabe96
{
    abstract class Figur
    {
        public string Name { get; private set; }
        public string Elementtyp { get; private set; }

        public static int AnzahlFiguren;

        public Figur(string name, string elementtyp)
        {
            Name = name;
            Elementtyp = elementtyp;
            AnzahlFiguren++;
        }

        public abstract double Umfang();
        public abstract double Flaeche();

        public override string ToString()
        {
            return $"Name: {Name}, Typ: {Elementtyp}";
        }
    }
}