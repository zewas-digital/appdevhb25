namespace Appdevhb25.JulianMatt.Aufgabe84
{
    public class Fotoapparat : IGegenstand
    {
        public string InventoryNumber { get; set; }
        public double Brennweite;
        public Fotoapparat(double brennweite, string inventoryNumber)
        {
            InventoryNumber = inventoryNumber;
            Brennweite = brennweite;
        }

        public string GetGegenstandInfo()
        {
            return $"Das ist ein Fotoapparat mit der Brennweite: {Brennweite} {InventoryNumber}";
        }
    }
}