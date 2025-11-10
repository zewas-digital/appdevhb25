namespace Appdevhb25.MarcelSimma.Week05.VererbungIntro
{
    public class Motorrad : Fahrzeug
    {

        public double Leistung;
        public double Kaufpreis;

        public static double Umsatz;

        public static int AnzahlDerProduziertenMotorraeder;

        public Motorrad(string farbe, double leistung, double kaufpreis) : base(farbe)
        {
            Leistung = leistung;
            Kaufpreis = kaufpreis;
            Umsatz += kaufpreis;
            AnzahlDerProduziertenMotorraeder++;
        }

        public override void DruckeDatenblatt()
        {
            base.DruckeDatenblatt();
            System.Console.WriteLine("Leistung: " + Leistung);
            System.Console.WriteLine("Kaufpreis: " + Kaufpreis);
        }

        public override string ToString()
        {
            return "Das ist ein Motorrad";
        }

        public static double BerechneDurchschnittsumsatzProMotorrad()
        {
            return Umsatz / AnzahlDerProduziertenMotorraeder;
        }

        public override void Fahren(double distance)
        {
            Kilometerstand += distance; 
        }
    }

}