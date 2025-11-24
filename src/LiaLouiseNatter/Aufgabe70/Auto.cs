using System.Runtime.ConstrainedExecution;

namespace Appdevhb25.LiaLouiseNatter.Aufgabe70
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

        public void Fahren(double distanz)
        {
            Distanz = distanz;
        }

        public override void DruckeDatenblatt()
        {
            base.DruckeDatenblatt();
            System.Console.WriteLine($"Km Stand: {Kilometerstand}\nGefahrene Distanz: {Distanz}\nNeuer Kilometerstand: {Kilometerstand + Distanz}");
        }
    }
}

