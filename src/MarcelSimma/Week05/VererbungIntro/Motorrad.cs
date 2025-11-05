namespace Appdevhb25.MarcelSimma.Week05.VererbungIntro
{
    public class Motorrad : Fahrzeug
    {

        public double Leistung;
        public double Kaufpreis;

        public static double Umsatz;

        public static int AnzahlDerProduziertenMotorräder;

        public Motorrad(string farbe, double leistung, double kaufpreis) : base(farbe)
        {
            Leistung = leistung;
            Kaufpreis = kaufpreis;
        }

        public override void DruckeDatenblatt()
        {
            base.DruckeDatenblatt();
            System.Console.WriteLine("Leistung: " + Leistung);
            System.Console.WriteLine("Kaufpreis: " + Kaufpreis);
        }
    }

}