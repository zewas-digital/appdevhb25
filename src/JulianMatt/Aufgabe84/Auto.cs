namespace Appdevhb25.JulianMatt.Aufgabe84
{

    public class Auto : IGegenstand
    {

        public string InventoryNumber { get; private set; }
        private int _anzahlDerTueren;
        public int AnzahlDerTueren
        {
            get
            {
                return _anzahlDerTueren;
            }
            set
            {
                _anzahlDerTueren = value;
            }
        }
        public Auto(int anzahlDerTueren, string inventoryNumber)
        {
            InventoryNumber = inventoryNumber;
            AnzahlDerTueren = anzahlDerTueren;
        }

        public string GetGegenstandInfo()
        {
            return $"Das ist ein Auto mit {AnzahlDerTueren} Türen {InventoryNumber}";
        }

    }
}