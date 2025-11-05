using Appdevhb25.MarcelSimma.Week05.VererbungIntro;

namespace Appdevhb25.MarcelSimma.Week05.Aufgabe65
{
    public class Vererbung
    {
        public static void Start()
        {
            Fahrzeug f1 = new Fahrzeug("rot");
            //f1.Farbe = "grün"; // funktioniert nicht, weil setter private ist

            f1.DruckeDatenblatt();

            Motorrad m1 = new Motorrad("schwarz", 50, 20_000);

            Auto a1 = new Auto("gelb", 5);

            m1.DruckeDatenblatt();
            f1.DruckeDatenblatt();
            a1.DruckeDatenblatt();

        }
    }
}