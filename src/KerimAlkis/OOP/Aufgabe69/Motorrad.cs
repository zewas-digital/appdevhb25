using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.KerimAlkis.Aufgabe69
{
    public class MotorradAufgabe
    {
        public static void Start()
        {
            Motorrad m1 = new Motorrad(10_000, "schwarz", 100, 20_000);
            Motorrad m2 = new Motorrad(50_000, "weiß", 100, 20_000);
            Motorrad m3 = new Motorrad(80_000, "schwarz", 100, 20_000);

            Motorrad.AnzahlMotorrad();
            Motorrad.BerechneDurchschnittsumsatz();
        }

    }

    public class Motorrad
    {

        public static int MotorradAnzahl;
        public static double Umsatz;


        public int Kilometerstand { get{ return _kilometerstand; }
            set
            {
                if (value > _kilometerstand)
                {
                    _kilometerstand = value;
                }
                else{ Console.WriteLine("Der Kilometerstand kann nicht weniger sein als davor"); }
            } }
        private int _kilometerstand;

        public string Farbe { get; private set; }


        public int Leistung { get{ return _leistung; }
            set
            {
                if (value > 0)
                {
                    _leistung = value;
                }
                else{System.Console.WriteLine("Die Leistung kann nicht negativ sein");}
            }
        }
        private int _leistung;

        public double Kaufpreis { get{ return _kaufpreis; }
            set
            {
                if (value > 0)
                {
                    _kaufpreis = value;
                }
                else{System.Console.WriteLine("Der Kaufpreis kann nicht negativ sein");}
            }
        }
        private double _kaufpreis;



        public Motorrad(int kilometerstand, string farbe, int leistung, double kaufpreis)
        {
            Kilometerstand = kilometerstand;
            Farbe = farbe;
            Leistung = leistung;
            Kaufpreis = kaufpreis;

            MotorradAnzahl++;
            Umsatz += kaufpreis;
        }

        public void Daten()
        {
            System.Console.WriteLine("Kilometerstand: " + Kilometerstand);
            System.Console.WriteLine("Farbe: " + Farbe);
            System.Console.WriteLine("Leistung: " + Leistung);
            System.Console.WriteLine("Kaufpreis: "+ Kaufpreis);
        }
        public static void AnzahlMotorrad()
        {
            System.Console.WriteLine("Anzahl der Motorräder: " + MotorradAnzahl);
        }
        public static void BerechneDurchschnittsumsatz()
        {
            Console.WriteLine("Durchschnittsumsatz: " + Umsatz / MotorradAnzahl);
        }
    }
}