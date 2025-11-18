namespace Appdevhb25.JulianMatt.Aufgabe84
{

    public class Auto : Fahrzeug
    {
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
        public Auto(int anzahlDerTueren, string fahrgestellnummer) : base(fahrgestellnummer)
        {
            AnzahlDerTueren = anzahlDerTueren;
        }
        public string GetGegenstandInfo()
        {
            return $"Das ist ein Auto mit {AnzahlDerTueren} Türen";
        }

    }
}