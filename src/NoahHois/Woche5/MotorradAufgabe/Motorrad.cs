using System;
using System.Net;
using Appdevhb25.NoahHois.Aufgabe69;

namespace Appdevhb25.NoahHois.Aufgabe69
{
    public class Motorrad
    {
        private int _mileage;
        public int Mileage
        {
            get
            {
                return _mileage;
            }
            set
            {
                if (value > _mileage)
                {
                    _mileage = value;
                }
                else
                {
                    Console.WriteLine("Der Kilometerstand darf nicht zurückgedreht werden.");
                }
            }
        }
        private MotorcycleColor _color;
        public MotorcycleColor Color
        {
            get
            {
                return _color;
            }
            set
            {
                if (Enum.IsDefined(typeof(MotorcycleColor), value))
                {
                    _color = value;
                }
                else
                {
                    Console.WriteLine("Die Farbe konnte nicht gefunden werden");
                }
            }

        }

        private int _horsepower;
        public int Horsepower
        {
            get
            {
                return _horsepower;
            }
            set
            {
                if (value > _horsepower)
                {
                    _horsepower = value;
                }
                else
                {
                    Console.WriteLine("Wieso solltest du weniger ps haben wollen?");
                }
            }
        }
        private int _purchasePrice;
        public int PurchasePrice
        {
            get
            {
                return _purchasePrice;
            }
            set
            {
                _purchasePrice = value;
            }
        }
        private string _mark;
        public string Mark
        {
            get
            {
                return _mark;
            }
            private set
            {
                _mark = value;
            }
        }
        public static int anzahlMotorräder;
        public static double umstatz;
        public Motorrad(int mileage, MotorcycleColor color, int horsepower, int purchasePrice, string mark)
        {
            Mileage = mileage;
            Color = color;
            Horsepower = horsepower;
            PurchasePrice = purchasePrice;
            Mark = mark;
            anzahlMotorräder++;
            umstatz += PurchasePrice;
        }
        public Motorrad()
        {
            Mileage = 100;
            Color = MotorcycleColor.ROT;
            Horsepower = 100;
            PurchasePrice = 15_000;
            Mark = "-";
        }

        public static double BerechneDurchschnittsumsatz()
        {
            return umstatz / anzahlMotorräder;
        }

        public void Print()
        {
            Console.WriteLine("Kilometerstand " + Mileage);
            Console.WriteLine("Farbe " + Color);
            Console.WriteLine("PS " + Horsepower);
            Console.WriteLine("Kaufpreis " + PurchasePrice);
            Console.WriteLine("Kennzeichen " + Mark);
            System.Console.WriteLine("Durchschnittsumsatz " + BerechneDurchschnittsumsatz());
        }
    }
}