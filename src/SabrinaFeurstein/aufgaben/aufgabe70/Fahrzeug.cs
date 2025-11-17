using System.Text.RegularExpressions;

namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe70
{
    public class Fahrzeug
    {
        private string? _farbe;
        private string? _kennzeichen;
        private double _kilometerstand;

        public string Farbe
        {
            get
            {
                return _farbe!;
            }
            private set
            {
                _farbe = value;
            }
        }
        public string Kennzeichen
        {
            get
            {
                return _kennzeichen!;
            }
            set
            {
                if (Regex.IsMatch(value, @"^([A-Z]{1,2})([- ]{1})([1-9]){1}(([0-9]{0,2})( ?)([A-NP-Z]{1})([A-Z]{2})||([0-9]{1,3})( ?)([A-NP-Z]{1})([A-Z]{1})||([0-9]{2,4})( ?)([A-NP-Z]{1}))$"))
                    _kennzeichen = value;
                else
                    Console.WriteLine("Ungültiges Kennzeichen!");
            }
        }
        public double Kilometerstand
        {
            get
            {
                return _kilometerstand;
            }
            set
            {
                if (value >= _kilometerstand)
                    _kilometerstand = value;
                else if (value < 0)
                    Console.WriteLine("Kilometerstand kann nicht negativ sein!");
                else
                    Console.WriteLine("Kilometerstand darf nicht zurückgesetzt werden!");
            }
        }

        public static int AnzahlDerProduziertenFahrzeuge;

        public Fahrzeug(string farbe, string kennzeichen, double kilometerstand)
        {
            Farbe = farbe;
            Kennzeichen = kennzeichen;
            Kilometerstand = kilometerstand;
        }

        public virtual void DruckeDatenblatt()
        {
            Console.WriteLine($"Farbe: {Farbe}\nKennzeichen: {Kennzeichen}\nKilometerstand: {Kilometerstand} km");
        }
    }
}