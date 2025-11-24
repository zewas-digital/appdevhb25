using System.Text.RegularExpressions;

namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe69
{
    public class Motorrad
    {
        public static int AnzahlDerProduziertenMotorräder;
        public static int Umsatz;
        private int _kilometerstand;
        public int Kilometerstand
        {
            get
            {
                return _kilometerstand;
            }
            set
            {
                if (value >= _kilometerstand)
                {
                    _kilometerstand = value;
                }
                else
                {
                    Console.WriteLine("Der Kilometerstand kann nicht weniger werden");
                }
            }
        }
        private string _farbe;
        public string Farbe
        {
            get
            {
                return _farbe;
            }
            set
            {
                if (value == "schwarz" || value == "rot" || value == "blau" || value == "grün" || value == "violett" || value == "weiß" || value == "rosarot")
                {
                    _farbe = value;
                }
                else
                {
                    Console.WriteLine("Diese Farbe steht nicht zur Verfügung");
                }
            }
        }
        private int _leistung;
        public int Leistung
        {
            get
            {
                return _leistung;
            }
            set
            {
                if (value < 10)
                {
                    Console.WriteLine("Das ist viel zu wenig Leistung");
                }
                else
                {
                    _leistung = value;
                }
            }
        }
        private int _kaufpreis;
        public int Kaufpreis
        {
            get
            {
                return _kaufpreis;
            }
            set
            {
                if (value == 0)
                {
                    Console.WriteLine("Man verschenkt keine Motorräder.");
                }
                else if (value < 0)
                {
                    Console.WriteLine("Der Preis kann nicht negativ sein.");
                }
                else
                {
                    _kaufpreis = value;
                }
            }
        }

        private string _kennzeichen;
        public string Kennzeichen
        {
            get
            {
                return _kennzeichen;
            }
            set
            {
                if (!Regex.IsMatch(value, @"^(?=.*[A-Z])(?=.*[0-9])$"))
                {
                    _kennzeichen = value;
                }
                else
                {
                    Console.WriteLine("Ein Kennzeichen braucht Buchstaben und Zahlen");
                }
            }
        }
        public Motorrad(int kilometerstand, string farbe, int leistung, int kaufpreis, string kennzeichen)
        {
            Kilometerstand = kilometerstand;
            Farbe = farbe;
            Leistung = leistung;
            Kaufpreis = kaufpreis;
            Kennzeichen = kennzeichen;
        }
        public Motorrad(string farbe, int leistung, int kaufpreis)
        {
            Kilometerstand = 0;
            Farbe = farbe;
            Leistung = leistung;
            Kaufpreis = kaufpreis;
        }

        public void PrintAlt()
        {
            Console.WriteLine("Kilometerstand: " + Kilometerstand);
            Console.WriteLine("Farbe: " + Farbe);
            Console.WriteLine("Leistung: " + Leistung);
            Console.WriteLine("Kaufpreis: " + Kaufpreis);
            Console.WriteLine("Kennzeichen: " + Kennzeichen);
        }

        public void PrintNeu()
        {
            Console.WriteLine("Kilometerstand: 0");
            Console.WriteLine("Farbe: " + Farbe);
            Console.WriteLine("Leistung: " + Leistung);
            Console.WriteLine("Kaufpreis: " + Kaufpreis);
        }
        public static void PrintAnzahlDerProduziertenMotorräder()
        {
            Console.WriteLine();
            Console.WriteLine("Anzahl der produzierten Motorräder: " + AnzahlDerProduziertenMotorräder);
        }
        public static void PrintUmsatz()
        {
            Console.WriteLine("Umsatz: " + Umsatz);
        }
        public static double BerechneDurschnittsumsatz()
        {
            return Umsatz / AnzahlDerProduziertenMotorräder;
        }
    }
}