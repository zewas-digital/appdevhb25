using System;

namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe76
{
    public class Person
    {
        private string _name;
        public string Name
        {
            get { return _name; }
        }
        private int _alter;
        public int Alter
        {
            get { return _alter; }
        }
        private double _groesse;
        public double Groesse
        {
            get { return _groesse; }
        }
        private double _gewicht;
        public double Gewicht
        {
            get { return _gewicht; }
        }
        private string _sozialversicherungsnummer;
        public string Sozialversicherungsnummer
        {
            get { return _sozialversicherungsnummer; }
        }

        public Person(string name, int alter, double groesse, double gewicht, string sozialversicherungsnummer)
        {
            _name = name;
            _alter = alter;
            _groesse = groesse;
            _gewicht = gewicht;
            _sozialversicherungsnummer = sozialversicherungsnummer;
        }

        public override string ToString()
        {
            return $"{Name} ({Alter}) - {Groesse:F2} m - {Gewicht} kg, SZ-Nummer: {Sozialversicherungsnummer}";
        }
    }
}