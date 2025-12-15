using System;
namespace Appdevhb25.KatjaHaemmerli.Aufgabe88UML
{
    public interface IGegenstand
    {
        public string Marke { get; set; }
        public string Farbe { get; set; }
        public string Seriennummer { get; set; }

        public void AusgabeDerAttribute();

    }
}