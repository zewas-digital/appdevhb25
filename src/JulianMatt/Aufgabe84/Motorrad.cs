namespace Appdevhb25.JulianMatt.Aufgabe84
{
    public class Motorrad : Fahrzeug
    {
        public string Marke;
        public Motorrad(string marke, string fahrgestellnummer) : base(fahrgestellnummer)
        {
            Marke = marke;
        }

        public string GetGegenstandInfo()
        {
            return $"Das ist ein Motorrad von der Marke {Marke}";
        }
    }
}