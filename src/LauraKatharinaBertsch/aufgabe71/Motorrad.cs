namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe71
{
    public class Motorrad : AbstrakteFahrzeuge
    {
        public static int AnzahlDerProduziertenMotorräder;
        public static double Umsatz;
        public double _leistung;
        public double _kaufpreis;
        public double Leistung
        {
            get
            {
                return _leistung;
            }
            set
            {
                if (value < 10)
                {
                    Console.WriteLine("Das ist zu wenig Leistung.");
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
                if (value == 0)
                {
                    Console.WriteLine("Man verschenkt keine Motorräder.");
                }
                else if (value < 0)
                {
                    Console.WriteLine("Der Preis kann nicht negativ sein.");
                }
                else
                {
                    _kaufpreis = value;
                }
            }
        }

        public Motorrad(double leistung, double kaufpreis) : base("schwarz", "AT456", 0)
        {
            Leistung = leistung;
            Kaufpreis = kaufpreis;
            AnzahlDerProduziertenMotorräder++;
            Umsatz = Umsatz + Kaufpreis;
        }
        public override void DruckeDatenblatt()
        {
            base.DruckeDatenblatt();
            Console.WriteLine("Leistung: " + Leistung);
            Console.WriteLine("Kaufpreis: " + Kaufpreis);
        }

        public override void Fahren(double distanz)
        {
            Kilometerstand += distanz;
            Console.WriteLine("Distanz: " + distanz);
            Console.WriteLine("neuer Kilometerstand: " + Kilometerstand);
        }
        public static double BerechneDurchschnittsumsatz()
        {
            return Umsatz / AnzahlDerProduziertenMotorräder;
        }
        public override string ToString()
        {
            return "Das ist ein Motorrad";
        }
    }
}