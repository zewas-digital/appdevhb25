using System;
using System.Text.RegularExpressions;

namespace Appdevhb25.SelinUlutuerk.Aufgabe71
{
    public abstract class Fahrzeug
    {
        public string Farbe {get; private set;}
        private string? _kennzeichen ;
        private double _kilometerstand;
        public static int AnzahlDerProduziertenFahrzeuge = 0;


        public string? Kennzeichen
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

        public Fahrzeug(string farbe, string kennzeichen, double kilometerstand )
        {
            Farbe = farbe;
            Kilometerstand = kilometerstand;
            Kennzeichen = kennzeichen;

            AnzahlDerProduziertenFahrzeuge++;
        }

        public virtual string DruckeDatenblatt()
        {
            return $"Farbe: {Farbe}\nKennzeichen: {Kennzeichen}\nKilometerstand: {Kilometerstand}\n";
        }

        public void Fahren(double distanz)
        {
            Kilometerstand += distanz;

            // double alterKilometerstand = Kilometerstand;
            // double neuerKilometerstand = alterKilometerstand + distanz;

            // Console.WriteLine($"Alter Kilometerstand: {alterKilometerstand} km");
            // Console.WriteLine($"Gefahrene Distanz: {distanz} km");
            // Console.WriteLine($"Neuer Kilometerstand: {neuerKilometerstand} km");
            // System.Console.WriteLine();
            
            // Kilometerstand = neuerKilometerstand;
        }
    }
}