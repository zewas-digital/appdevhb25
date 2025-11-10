using System.Globalization;
using System.Net.WebSockets;

namespace Appdevhb25.JonaSchnell.Aufgabe66
{
    public class Personen
    {
        private double _größe;
        public double Größe
        {
            get { return _größe; }
            set
            {
                if (value <= 0)
                {
                    System.Console.WriteLine("Du kannst nicht so klein sein.");
                }
                else if (value >= 272)
                {
                    System.Console.WriteLine("Du bist die größte person der Welt.");
                }
                else
                {
                    value = _größe;
                }
            }
        }
        public void PrintGröße()
        {
            System.Console.WriteLine("Du bist " + Größe + " cm groß.");
        }


        private DateTime _geburtsdatum;
        public DateTime Geburtsdatum
        {
            get { return _geburtsdatum; }
            set
            {
                if (Convert.ToDateTime(value) >= Convert.ToDateTime(Geburtsdatum - DateTime.Now))
                {
                    System.Console.WriteLine("Das ist zu alt.");
                }
                else if (value >= Geburtsdatum)
                {
                    System.Console.WriteLine("Du lebst noch garnicht");
                }
                else
                {
                    value = _geburtsdatum;
                }
            }
        }

        public void PrintGeburtsdatum()
        {
            CultureInfo austrian = new CultureInfo("de-AT");
            System.Console.WriteLine("Du hast am " + Geburtsdatum.ToString("dd.MM.yyyy", austrian) + " Geburtstag.");
        }

        public string Name = string.Empty;
        public void PrintName()
        {
            System.Console.WriteLine("Dein Name ist " + Name + ".");
        }
        private double _gewicht
        {
            get { return _gewicht; }
            set
            {
                if (value <= 0)
                {
                    System.Console.WriteLine("Du bist zu Leicht.");
                }
                else
                {
                    value = _gewicht;
                }
            }
        }
        public double Gewicht;
        public void PrintGewicht()
        {
            System.Console.WriteLine("Du bist " + Gewicht + " kg schwer!");
        }
        public void Print()
        {
            PrintName();
            PrintGeburtsdatum();
            PrintGröße();
            PrintGewicht();
            Altersberechnung();
        }
        public void Altersberechnung()
        {
            DateTime now = DateTime.Now;
            int alter = now.Year - Geburtsdatum.Year;
            System.Console.WriteLine("Du bist " + alter + " Jahre alt.");
        }
    }
}