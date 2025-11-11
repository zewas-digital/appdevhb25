using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Appdevhb25.NoahHois.Aufgabe71
{
    public abstract class Fahrzeuge
    {

        public string Color;
        public string Mark;
        private double _mileage;
        public double Mileage
        {
            get
            {
                return _mileage;
            }
            set
            {
                if (value >= _mileage)
                {
                    _mileage = value;
                }
                else
                {
                    System.Console.WriteLine("Man kann den Kilometerstand nicht zurücksetzen.");
                }
            }
        }

        public static int AnzahlDerProduziertenFahrzeuge;

        public Fahrzeuge(string color, string mark, double mileage)
        {
            Color = color;
            Mark = mark;
            Mileage = mileage;
            AnzahlDerProduziertenFahrzeuge++;
        }

        public virtual void DruckeDatenblatt()
        {
            System.Console.WriteLine("Farbe " + Color);
            System.Console.WriteLine("Kennzeichen " + Mark);
            System.Console.WriteLine("Kilometerstand " + Mileage);
        }

        public abstract void Fahren(double distanz);
    }
    public class Auto : Fahrzeuge
    {
        public int AmountOfDoors;
        public static int AnzahlDerProduziertenAutos;

        public Auto(int amountOfDoors, string color, string mark, double mileage) : base(color, mark, mileage)
        {
            AmountOfDoors = amountOfDoors;
            AnzahlDerProduziertenAutos++;
        }
        public override void DruckeDatenblatt()
        {
            base.DruckeDatenblatt();
            System.Console.WriteLine("Anzahl Türen " + AmountOfDoors);
            PrintAnzahlDerAutos();
            System.Console.WriteLine();
        }
        public override void Fahren(double distanz)
        {
            Mileage += distanz;
            System.Console.WriteLine("Neuer Kilometerstand: " + Mileage);
        }
        public void PrintAnzahlDerAutos()
        {
            System.Console.WriteLine("Anzahl Autos " + AnzahlDerProduziertenAutos);
        }
        public override string ToString()
        {
            return "Das ist ein Auto";
        }

    }

    public class Motorrad : Fahrzeuge
    {
        public double Horsepower;
        public double PurchasePrice;
        public static double SalesVolume;
        public static int AnzahlDerProduziertenMotorraeder;

        public Motorrad(double horsepower, double purchasePrice, string color, string mark, double mileage) : base(color, mark, mileage)
        {
            Horsepower = horsepower;
            PurchasePrice = purchasePrice;
            SalesVolume += PurchasePrice;
            AnzahlDerProduziertenMotorraeder++;
        }
        public override void DruckeDatenblatt()
        {
            base.DruckeDatenblatt();
            System.Console.WriteLine("PS " + Horsepower);
            System.Console.WriteLine("Kaufpreis " + PurchasePrice);
            System.Console.WriteLine("Durchschnitt: " + BerechneDurchschnittsumsatz());
            System.Console.WriteLine();
        }
        public static double BerechneDurchschnittsumsatz()
        {
            return SalesVolume / AnzahlDerProduziertenMotorraeder;
        }
        public override void Fahren(double distanz)
        {
            Mileage += distanz;
            System.Console.WriteLine("Neuer Kilometerstand: " + Mileage);
        }
        public override string ToString()
        {
            return "Das ist ein Motorrad";
        }
    }
}