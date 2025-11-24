namespace Appdevhb25.SelinUlutuerk.Aufgabe84
{
    public class Motorrad : IGegenstand
    {
        public string Inventarnummer { get; set; } = string.Empty;
        public string Marke;
        
        public Motorrad(string marke)
        {
            Marke = marke;
        }

        public string PrintGegenstand()
        {
            return "Das ist ein Motorrad";
        }
    }
}