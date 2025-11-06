namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe70
{
    public class Motorrad : Fahrzeug
    {
        private double _leistung;
        private double _kaufpreis;
        public double Leistung
        {
            get
            {
                return _leistung;
            }
            set
            {
                if (value >= 0)
                    _leistung = value;
                else
                    Console.WriteLine("Leistung kann nicht negativ sein!");
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
                if (value >= 0)
                    _kaufpreis = value;
                else
                    Console.WriteLine("Kaufpreis kann nicht negativ sein!");
            }
        }

        public static double Umsatz;
        public static int AnzahlDerProduziertenMotorraeder;

        public Motorrad(string farbe, string kennzeichen, double kilometerstand, double leistung, double kaufpreis) : base(farbe, kennzeichen, kilometerstand)
        {
            Leistung = leistung;
            Kaufpreis = kaufpreis;
            Umsatz += Kaufpreis;
            AnzahlDerProduziertenMotorraeder++;
            AnzahlDerProduziertenFahrzeuge++;
        }

        public static double BerechneDurchschnittsUmsatz()
        {
            return Umsatz / AnzahlDerProduziertenMotorraeder;
        }

        public override void DruckeDatenblatt()
        {
            base.DruckeDatenblatt();
            Console.WriteLine($"Leistung: {Leistung} kW\nKaufpreis: {Kaufpreis:F2} EUR");
        }
    }
}