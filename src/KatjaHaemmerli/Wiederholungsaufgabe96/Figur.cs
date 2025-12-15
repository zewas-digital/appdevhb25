using System;
namespace Appdevhb25.KatjaHaemmerli.Widerholungsaufgabe96
{
    public abstract class Figur
    {
        // von abastracten Klassen können keine Objekte erzeugt werden 
        private string FigurName;
        private string ElementTyp;
        
        public abstract double FlaecheBerechnen();
        public abstract double UmfangBerechnen();
    }
}