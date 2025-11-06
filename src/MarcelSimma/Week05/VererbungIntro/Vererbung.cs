using Appdevhb25.MarcelSimma.Week05.VererbungIntro;

namespace Appdevhb25.MarcelSimma.Week05.Aufgabe65
{
    public class Vererbung
    {
        public static void Start()
        {
            // Fahrzeug f1 = new Fahrzeug("rot"); funktioniert nicht, weil Fahrzeug abstrakt ist.
            //f1.Farbe = "grün"; // funktioniert nicht, weil setter private ist

            //f1.DruckeDatenblatt();

            Motorrad m1 = new Motorrad("FarbeMotorradM1", 50, 20_000);
            Motorrad m2 = new Motorrad("FarbeMotorradM2", 50, 10_000);

            Auto a1 = new Auto("FarbeAutoA1", 5);
            Auto a2 = new Auto("FarbeAutoA2", 5);

            Auto[] autos = new Auto[2];
            Motorrad[] motorraeder = new Motorrad[2];
            Fahrzeug[] fahrzeuge = new Fahrzeug[5];

            fahrzeuge[0] = new Auto("grün", 3);
            fahrzeuge[1] = a1;
            fahrzeuge[2] = a2;
            fahrzeuge[3] = m1;
            fahrzeuge[4] = m2;

            foreach (Fahrzeug fahrzeug in fahrzeuge)
            {
                fahrzeug.Fahren(100);
                fahrzeug.DruckeDatenblatt();
                Console.WriteLine(fahrzeug.ToString());

            }


            Console.WriteLine(Motorrad.BerechneDurchschnittsumsatzProMotorrad());
            Console.WriteLine(Fahrzeug.AnzahlDerProduziertenFahrzeuge);
            System.Console.WriteLine(Auto.AnzahlDerProduziertenFahrzeuge);

        }
    }
}