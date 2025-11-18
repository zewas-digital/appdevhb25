using System.Text.RegularExpressions;

namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe69
{
    public class Motorrad
    {
        private double _kilometerstand;
        private string? _farbe;
        private int _leistung;
        private double _kaufpreis;
        private string? _kennzeichen;
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
        public string Farbe
        {
            get
            {
                return _farbe!;
            }
            private set
            {
                _farbe = value!;
            }
        }
        public int Leistung
        {
            get
            {
                return _leistung;
            }
            set
            {
                if (value >= 0)
                    _leistung = value;
                else
                    Console.WriteLine("Leistung kann nicht negativ sein!");
            }
        }
        public double Kaufpreis
        {
            get
            {
                return _kaufpreis;
            }
            set
            {
                if (value >= 0)
                    _kaufpreis = value;
                else
                    Console.WriteLine("Kaufpreis kann nicht negativ sein!");
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

        public static int ProduzierteMotorraeder;
        public static double Umsatz;

        public Motorrad(double kilometerstand, string farbe, int leistung, double kaufpreis, string kennzeichen)
        {
            Kilometerstand = kilometerstand;
            Farbe = farbe;
            Leistung = leistung;
            Kaufpreis = kaufpreis;
            Kennzeichen = kennzeichen;

            ProduzierteMotorraeder++;
            Umsatz += Kaufpreis;
        }
        public Motorrad(string farbe, int leistung, double kaufpreis, string kennzeichen)
        {
            Kilometerstand = 0;
            Farbe = farbe;
            Leistung = leistung;
            Kaufpreis = kaufpreis;
            Kennzeichen = kennzeichen;

            ProduzierteMotorraeder++;
            Umsatz += Kaufpreis;
        }

        public static double BerechneDurchschnittsUmsatz()
        {
            return Umsatz / ProduzierteMotorraeder;
        }
    }
}