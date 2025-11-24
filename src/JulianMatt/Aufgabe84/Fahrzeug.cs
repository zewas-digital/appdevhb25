namespace Appdevhb25.JulianMatt.Aufgabe84
{
    public class Fahrzeug : IGegenstand
    {
        public string InventoryNumber { get; private set; }
        public string Fahrgestellnummer;
        public Fahrzeug(string fahrgestellnummer)
        {
            Fahrgestellnummer = fahrgestellnummer;
        }

        public string GetGegenstandInfo()
        {
            return $"Das ist ein Fahrzeug mit der Fahrestellnummer: {Fahrgestellnummer}";
        }
    }
}