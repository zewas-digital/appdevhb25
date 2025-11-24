using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;

namespace Appdevhb25.KerimAlkis.Aufgabe71
{
    public class Fahrzeuge
    {
        public static void Start()
        {
            Auto auto1 = new Auto("Rot", "ZH-12345", 15000, 5);
            Auto auto2 = new Auto("Blau", "BE-98765", 42000, 3);
            Auto auto3 = new Auto("Schwarz", "SG-11111", 9000, 4);
            
            Motorrad motorrad1 = new Motorrad("Silber", "LU-20202", 8000, 80, 12000);
            Motorrad motorrad2 = new Motorrad("Weiß", "AG-30303", 12000, 110, 15000);
            Motorrad motorrad3 = new Motorrad("Rot", "ZH-40404", 500, 95, 13500);

            List<Fahrzeug> fahrzeuge = new List<Fahrzeug>{auto1, auto2, auto3, motorrad1, motorrad2, motorrad3};

            System.Console.WriteLine("\n--- DATENBLÄTTER ---");
            foreach (Fahrzeug fahrzeug in fahrzeuge)
            {
                Console.WriteLine(fahrzeug.ToString());
                fahrzeug.DrueckeDatenblatt();
                System.Console.WriteLine();
            }
            Console.WriteLine(new string('-', 20));
            System.Console.WriteLine();

            auto1.Fahren(120);
            auto2.Fahren(350);
            motorrad1.Fahren(200);
            motorrad3.Fahren(-50);
            Console.WriteLine(new string('-', 20));
            System.Console.WriteLine();

            Motorrad.BerechneDurchschnittsUmsatz();
            Console.WriteLine("Anzahl der produzierten Fahrzeugen: " + Fahrzeug.AnzahlDerProduziertenFahrzeugen);
            Console.WriteLine("Anzahl der produzierten Autos: " + Auto.AnzahlDerProduziertenAutos);
            Console.WriteLine("Anzahl der produzierten Motorraeder: " + Motorrad.AnzahlDerProduziertenMotorraeder);

        }

    }

    public abstract class Fahrzeug
    {
        public string Farbe;
        public string Kennzeichen;
        private double _kilometerstand;
        public double Kilometerstand{ get{ return _kilometerstand; }
            private set
            {
                if (value >= _kilometerstand)
                {
                    _kilometerstand = value;    
                }
                else
                {
                    Console.WriteLine("Der Kilometerstand kann nicht zurückgedreht werden");
                }
            } 
        }



        public static int AnzahlDerProduziertenFahrzeugen;

        public Fahrzeug(string farbe, string kennzeichen, double kilometerstand)
        {
            Farbe = farbe;
            Kennzeichen = kennzeichen;
            Kilometerstand = kilometerstand;

            AnzahlDerProduziertenFahrzeugen++;
        }


        public virtual void DrueckeDatenblatt()
        {
            System.Console.WriteLine("Farbe: " + Farbe);
            System.Console.WriteLine("Kennzeichen: " + Kennzeichen);
            System.Console.WriteLine("Kilometerstand: " + Kilometerstand);
        }
        public virtual void Fahren(double distanz)
        {
            if (distanz < 0)
            {
                Console.WriteLine("Negative Distanz ist nicht erlaubt.");
                System.Console.WriteLine();
                return;
            }

            System.Console.WriteLine($"alter Kilometerstand: {Kilometerstand}\ngefahrene Distanz: {distanz}");
            Kilometerstand += distanz;
            System.Console.WriteLine("neuer Kilometerstand: " + Kilometerstand);
            System.Console.WriteLine();
        }
    }




    public class Auto : Fahrzeug
    {
        public int AnzahlDerTueren { get; private set; }
        
        public static int AnzahlDerProduziertenAutos;


        public Auto(string farbe, string kennzeichen, double kilometerstand, int anzahlDerTueren) : base(farbe, kennzeichen, kilometerstand)
        {
            AnzahlDerTueren = anzahlDerTueren;
            AnzahlDerProduziertenAutos++;
        }


        public override void DrueckeDatenblatt()
        {
            base.DrueckeDatenblatt();
            System.Console.WriteLine("AnzahlDerTueren: " + AnzahlDerTueren);
        }
        public override string ToString()
        {
            return "Das ist ein Auto";
        }
    }


    public class Motorrad : Fahrzeug
    {
        public double Leistung;
        public double Kaufpreis{ get; private set; }

        public static double Umsatz;
        public static int AnzahlDerProduziertenMotorraeder = 0;


        public Motorrad(string farbe, string kennzeichen, double kilometerstand, double leistung, double kaufpreis) : base(farbe, kennzeichen, kilometerstand)
        {
            Leistung = leistung;
            Kaufpreis = kaufpreis;

            Umsatz += kaufpreis;
            AnzahlDerProduziertenMotorraeder++;
        }


        public override void DrueckeDatenblatt()
        {
            base.DrueckeDatenblatt();
            System.Console.WriteLine("Leistung: " + Leistung);
            System.Console.WriteLine("Kaufpreis: " + Kaufpreis);
        }
        public static void BerechneDurchschnittsUmsatz()
        {
            System.Console.WriteLine("DurchschnittsUmsatz der Motorraeder: " + Umsatz / AnzahlDerProduziertenMotorraeder);
        }
        public override string ToString()
        {
            return "Das ist ein Motorrad";
        }

    }
}