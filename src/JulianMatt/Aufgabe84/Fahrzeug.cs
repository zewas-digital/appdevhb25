namespace Appdevhb25.JulianMatt.Aufgabe84
{
    public class Fahrzeug : IGegenstand
    {
        public string Fahrgestellnummer;

        public string InventoryNumber { get; set; }
        public Fahrzeug(string fahrgestellnummer, string inventoryNumber)
        {
            InventoryNumber = inventoryNumber;
            Fahrgestellnummer = fahrgestellnummer;
        }

        public string GetGegenstandInfo()
        {
            return $"Das ist ein Fahrzeug mit der Fahrestellnummer: {Fahrgestellnummer} {InventoryNumber}";
        }
    }
}