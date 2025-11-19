namespace Appdevhb25.SelinUlutuerk.Aufgabe84
{
    public class Fotoapparat : IGegenstand
    {
        public string Inventarnummer { get; set; } = string.Empty;
        public double Brennweite;
        public Fotoapparat(double brennweite)
        {
            brennweite = Brennweite;   
        }

        public string PrintGegenstand()
        {
            return "Das ist ein Fotoapparat";
        }
    }
}