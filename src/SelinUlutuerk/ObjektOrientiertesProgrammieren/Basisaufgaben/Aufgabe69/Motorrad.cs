using System;
using System.Text.RegularExpressions;

namespace Appdevhb25.SelinUlutuerk.Aufgabe69
{
    class Motorrad
    {
        private string? _farbe;
        private string? _kennzeichen;
        private double _kilometerstand;
        private double _leistung;
        private double _kaufpreis;

        public static int AnzahlMotorraeder = 0;
        public static double umsatz = 0;


        public string? Farbe
        {
            get
            {
                return _farbe;
            }
            set
            {
                _farbe = value;
            }
        }

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
                // Value ist nie null desegen hier ! angewendet (könnte aber auch if verwenden)
                if(Regex.IsMatch(value!.ToUpper(), pattern))
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

        public double Leistung
        {
            get
            {
                return _leistung;
            }
            set
            {
                if (_leistung < 0)
                {
                    System.Console.WriteLine("Leistung kann nicht negativ sein!");
                }
                else
                {
                    _leistung = value;
                }

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
                _kaufpreis = value;
            }
        }

        public Motorrad(double kilometerstand, string farbe, double leistung, double kaufpreis, string kennzeichen)
        {
            Kilometerstand = kilometerstand;
            Farbe = farbe;
            Leistung = leistung;
            Kaufpreis = kaufpreis;
            Kennzeichen = kennzeichen;
            AnzahlMotorraeder++;
            umsatz += kaufpreis;
        }

        public static void BerechneDurchschnittsumsatz()
        {
            System.Console.WriteLine($"Es wurden {AnzahlMotorraeder} Motorräder produziert.\nDer Durchschnittliche Umsatz beträgt nun {umsatz/AnzahlMotorraeder:F2}.");
        }
    }
}