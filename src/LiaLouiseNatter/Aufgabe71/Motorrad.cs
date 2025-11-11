using Appdevhb25.LiaLouiseNatter.Aufgabe69;

namespace Appdevhb25.LiaLouiseNatter.Aufgabe71
{
    public class Motorrad:Fahrzeuge
    {
        private double _leistung;
        public double Leistung
        {
            get
            {
                return _leistung;
            }
            set
            {
                if (value < 0)
                {
                    System.Console.WriteLine("Leistung muss Positiv sein");
                }
                else
                {
                    _leistung = value;
                }
            }
        }
        private double _kaufpreis;
        public double Kaufpreis
        {
            get
            {
                return _kaufpreis;
            }
            set
            {
                if (value < 0)
                {
                    System.Console.WriteLine("Kaufpreis muss Positiv sein");
                }
                else
                {
                    _kaufpreis = value;
                }
            }
        }
        public static double Umsatz;
        public static double DurchschnittlicherUmsatzProMotorrad;
        public static int AnzahlDerProduziertenMotorraeder;

        public Motorrad(string farbe, string kennzeichen, double kilometerstand, double leistung, double kaufpreis) : base(farbe, kennzeichen, kilometerstand)
        {
            Leistung = leistung;
            Kaufpreis = kaufpreis;
            AnzahlDerProduziertenMotorraeder++;
            Umsatz += Kaufpreis;
            DurchschnittlicherUmsatzProMotorrad = Umsatz / AnzahlDerProduziertenMotorraeder;
        }

        public override void Fahren(double distanz)
        {
            if (distanz <= 0)
            {
                System.Console.WriteLine("Distanz muss positiv sein.");
                return;
            }

            System.Console.WriteLine($"Km Stand: {Kilometerstand}\nGefahrene Distanz: {distanz}\nNeuer Kilometerstand: {Kilometerstand += distanz}");
            System.Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
        }

        public override void DruckeDatenblatt()
        {
            base.DruckeDatenblatt();
            System.Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
            System.Console.WriteLine("Motorrad: ");
            System.Console.WriteLine($"Leistung: {Leistung}\nKaufpreis:{Kaufpreis}\nUmsatz: {Umsatz}\nAnzahl der Produzierten Motorrädern: {AnzahlDerProduziertenMotorraeder}\nDurchschnittlicher Umsatz pro verkauftes Motorrad: {DurchschnittlicherUmsatzProMotorrad}");
            System.Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
        }


    }
}