using System.Runtime.ConstrainedExecution;

namespace Appdevhb25.LiaLouiseNatter.Aufgabe71
{
    public class Auto : Fahrzeuge
    {
        public int AnzahlDerTueren;
        public int AnzahlDerProduziertenAutos;
        private double _distanz;
        public double Distanz
        {
            get
            {
                return _distanz;
            }
            set
            {
                if (value < 0)
                {
                    System.Console.WriteLine("Distanz kann nicht im Minus Bereich sein");
                }
                else
                {
                    _distanz = value;
                }
            }
        }
        public Auto(string farbe, string kennzeichen, double kilometerstand, int anzahlDerTueren) : base(farbe, kennzeichen, kilometerstand)
        {
            AnzahlDerTueren = anzahlDerTueren;
            AnzahlDerProduziertenAutos++;
        }

        public override void Fahren(double distanz)
        {
            if (distanz <= 0)
            {
                System.Console.WriteLine("Die Distanz muss Positiv sein.");
                return;
            }
            Kilometerstand += distanz;
        }

      

        public override void DruckeDatenblatt()
        {
            System.Console.WriteLine("Auto: ");
            System.Console.WriteLine($"Km Stand: {Kilometerstand}\nGefahrene Distanz: {Distanz}\nNeuer Kilometerstand: {Kilometerstand + Distanz}");
            System.Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
        }
    }
}

