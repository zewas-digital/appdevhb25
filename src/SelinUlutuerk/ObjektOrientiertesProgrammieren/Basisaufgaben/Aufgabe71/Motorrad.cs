using System;

namespace Appdevhb25.SelinUlutuerk.Aufgabe71
{
    public class Motorrad : Fahrzeug
    {
        private double _leistung;
        public double Kaufpreis;
        public static double Umsatz = 0;
        public static int AnzahlDerProduziertenMotorräder = 0;

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

        public Motorrad(string farbe, double leistung, double kaufpreis) : base(farbe)
        {
            Leistung = leistung;
            Kaufpreis = kaufpreis;
            AnzahlDerProduziertenMotorräder++;
            Umsatz += kaufpreis;
        }

        public override void DruckeDatenblatt()
        {
            base.DruckeDatenblatt();
            System.Console.WriteLine("Leistung: " + Leistung);
            System.Console.WriteLine("Kaufpreis: " + Kaufpreis);
            System.Console.WriteLine(new string('-', 20));
        }

        public static void PrintAnzahlDerProduziertenMotorraeder()
        {
            System.Console.WriteLine("Anzahl der produzierten Autos: " + AnzahlDerProduziertenMotorräder);
        }

        public static void BerechneDurchschnittsumsatz()
        {
            System.Console.WriteLine($"Es wurden {AnzahlDerProduziertenMotorräder} Motorräder produziert.\nDer Durchschnittliche Umsatz beträgt nun {Umsatz/AnzahlDerProduziertenMotorräder:F2}.");
        }
    }
}