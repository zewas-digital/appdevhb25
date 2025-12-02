using System;
using System.Text.RegularExpressions;

namespace Appdevhb25.JonaSchnell.Aufgabe70
{
    public class Fahrzeug
    {
        private string _colour;
        private string _kennzeichen = "TEST123";
        private double _kilometerstand = 0;
        public static int carsMade = 0;


        public string colour
        {
            get
            {
                return _colour;
            }
            private set
            {
                _colour = value;
            }
        }

        public string Kennzeichen
        {
            get
            {
                return _kennzeichen;
            }
            set
            {
                if (_kennzeichen == Kennzeichen) { }
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
                if (value > _kilometerstand)
                {
                    _kilometerstand = value;
                }
            }
        }

        public Fahrzeug(string farbe)
        {
            colour = farbe;
            Kilometerstand = 0;
            Kennzeichen = "";

            carsMade++;
        }

        public virtual void DruckeDatenblatt()
        {
            System.Console.WriteLine("Farbe: " + colour);
            System.Console.WriteLine("Kennzeichen: " + Kennzeichen);
            System.Console.WriteLine("Kilometerstand: " + Kilometerstand);
        }
    }
}