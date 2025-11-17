using System.Globalization;
using System.Net.Mail;

namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe66
{
    public class Personen
    {

        public decimal Größe;

        public string Name;
        public decimal Gewicht;
        public int Alter;

        private DateTime _geburtsdatum;

        public DateTime Geburtsdatum
        {
            get
            {
                return _geburtsdatum;
            }
            set
            {
                if (value > new DateTime(1900, 01, 01))
                {
                    _geburtsdatum = value;
                }
                else
                {
                    Console.WriteLine("Das ist zu lange her");
                }
            }
        }

        public Personen(decimal groesse, DateTime geburtsdatum, string name, decimal gewicht)
        {
            Größe = groesse;
            Geburtsdatum = geburtsdatum;
            Name = name;
            Gewicht = gewicht;
        }

        public void Print()
        {
            Console.WriteLine("Größe: " + Größe + "m");
            Console.WriteLine("Geburtsdatum: " + Geburtsdatum.ToString("dd.MM.yyyy"));
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Gewicht: " + Gewicht + "kg");
        }
        public void GetBirthday()
        {
            DateTime currentDate = DateTime.Now;
            TimeSpan Alter = currentDate - Geburtsdatum;
            Console.WriteLine("Alter: " + Alter.Days / 365 + " Jahre");
        }
    }
}