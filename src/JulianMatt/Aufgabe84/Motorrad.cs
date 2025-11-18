namespace Appdevhb25.JulianMatt.Aufgabe84
{
    public class Motorrad : IGegenstand
    {
        public string InventoryNumber {get; set; }
        public string Marke;
        public Motorrad(string marke, string inventoryNumber)
        {
            InventoryNumber = inventoryNumber;
            Marke = marke;
        }

        public string GetGegenstandInfo()
        {
            return $"Das ist ein Motorrad von der Marke {Marke} {InventoryNumber}";
        }
    }
}