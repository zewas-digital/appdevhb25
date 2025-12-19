using System;
namespace Appdevhb25.KatjaHaemmerli.Aufgabe96
{
    public abstract class Figur
    {
        public string Name;
        public string Elementtyp;

        protected Figur(string name)
        {
            Name = name;
        }
        
        public abstract double Flaechenberechnung();

        public abstract double UmfangBerechnung();

        public void AusgabeFormenNamen()
        {            
            System.Console.WriteLine(Name);
        }
       
    }
}