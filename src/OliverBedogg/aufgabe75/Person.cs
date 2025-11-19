using System;

namespace Appdevhb25.OliverBedogg.aufgabe75
{
    public class Person
    {
        string _name;
        public string Name
        {
            get { return _name; }
        }
        int _alter;
        public int Alter
        {
            get { return _alter; }
        }
        double _groesse;
        public double Groesse
        {
            get { return _groesse; }
        }
        double _gewicht;
        public double Gewicht
        {
            get { return _gewicht; }
        }

        public Person(string name, int alter, double groesse, double gewicht)
        {
            _name = name;
            _alter = alter;
            _groesse = groesse;
            _gewicht = gewicht;
        }

        public override string ToString()
        {
            return _name;
        }
    }
}