using System;
using System.Text.RegularExpressions;

namespace Appdevhb25.SelinUlutuerk.Aufgabe71
{
    public abstract class Fahrzeug
    {
        private string _farbe;
        private string _kennzeichen = "";
        private double _kilometerstand = 0;
        public static int AnzahlDerProduziertenFahrzeuge = 0;


        public string Farbe
        {
            get
            {
                return _farbe;
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
                return _kennzeichen;
            }
            set
            {
                //\s? = kann Leerraum haben oder nicht
                string pattern = @"^[A-Z]{1,2}-[A-Z]{1,2}\s?[0-9]{1,4}$";
                if (Regex.IsMatch(value.ToUpper(), pattern))
                {
                    _kennzeichen = value.ToUpper();
                }
                else
                {
                    System.Console.WriteLine("Ungültiges Kennzeichenformat!");
                }
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
                else
                {
                    System.Console.WriteLine("Kilometerstand kann nicht verkleinert werden!");
                }
            }
        }

        public Fahrzeug(string farbe)
        {
            Farbe = farbe;
            Kilometerstand = 0;
            Kennzeichen = "";

            AnzahlDerProduziertenFahrzeuge++;
        }

        public virtual void DruckeDatenblatt()
        {
            System.Console.WriteLine("Farbe: " + Farbe);
            System.Console.WriteLine("Kennzeichen: " + Kennzeichen);
            System.Console.WriteLine("Kilometerstand: " + Kilometerstand);
        }
    }
}