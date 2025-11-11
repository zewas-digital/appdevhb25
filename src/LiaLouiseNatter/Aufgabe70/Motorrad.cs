namespace Appdevhb25.LiaLouiseNatter.Aufgabe70
{
    public class Motorrad : Fahrzeuge
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
        public double Umsatz;
        public double DurchschnittlicherUmsatzProMotorrad;
        public int AnzahlDerProduziertenMotorraeder;

        public Motorrad(string farbe, string kennzeichen, double kilometerstand, double leistung, double kaufpreis) : base(farbe, kennzeichen, kilometerstand)
        {
            Leistung = leistung;
            Kaufpreis = kaufpreis;
        }

        public double BerechneDurchschnittsUmsatz()
        {
            DurchschnittlicherUmsatzProMotorrad += Kaufpreis / AnzahlDerProduziertenMotorraeder;
            return DurchschnittlicherUmsatzProMotorrad;
        }

        public override void DruckeDatenblatt()
        {
            base.DruckeDatenblatt();
            System.Console.WriteLine($"Leistung: {Leistung}\nKaufpreis:{Kaufpreis}\nUmsatz: {Umsatz}\nAnzahl der Produzierten Motorrädern: {AnzahlDerProduziertenMotorraeder}\nDurchschnittlicher Umsatz pro verkauftes Motorrad: {DurchschnittlicherUmsatzProMotorrad}");
        }


    }
}