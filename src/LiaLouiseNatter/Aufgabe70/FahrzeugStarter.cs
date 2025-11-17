namespace Appdevhb25.LiaLouiseNatter.Aufgabe70
{
    public class FahrzeugStarter()
    {
        public static void Start()
        {
            Fahrzeuge f1 = new Fahrzeuge("red", "AT 12345", -1000);
            f1.DruckeDatenblatt();

            Fahrzeuge f2 = new Fahrzeuge("blue", "DE 67890", 1500);
            f2.DruckeDatenblatt();

            Fahrzeuge f3 = new Fahrzeuge("black", "CH 24680", 2000);
            f3.DruckeDatenblatt();

            Fahrzeuge f4 = new Fahrzeuge("white", "FR 11223", 1800);
            f4.DruckeDatenblatt();

            Fahrzeuge f5 = new Fahrzeuge("green", "IT 99887", 1200);
            f5.DruckeDatenblatt();

        }
    }
}