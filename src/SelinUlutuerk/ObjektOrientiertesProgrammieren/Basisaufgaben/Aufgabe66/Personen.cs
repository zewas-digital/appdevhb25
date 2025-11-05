using System;

namespace Appdevhb25.SelinUlutuerk.Aufgabe66
{
    class Personen
    {
        // Felder
        public double Groesse;
        public DateTime Geburtsdatum;
        public string Name;
        public double Gewicht;

        // Standardkonstruktor ist immer verfügbar
        public Personen()
        {

        }

        // Instanz Methode, weil es nicht static ist
        public void PrintPersonen()
        {
            System.Console.WriteLine(Name);
            System.Console.WriteLine(Groesse);
            System.Console.WriteLine(Geburtsdatum.ToString("d"));
            System.Console.WriteLine(Gewicht);
        }

        public void GetBirthday()
        {

            DateTime heute = DateTime.Now;
            int alter = heute.Year - Geburtsdatum.Year;
            System.Console.WriteLine(alter);
        }
    }
}