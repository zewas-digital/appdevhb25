using System;

namespace Appdevhb25.SelinUlutuerk.Aufgabe71
{
    class Vererbung
    {
        public static void Start()
        {
            // Fahrzeug f1 = new Fahrzeug("schwarz"); funktioniert nicht, weil Fahrzeug abstrakt ist.

            Motorrad m1 = new Motorrad("blau", 70, 4_000);
            Motorrad m2 = new Motorrad("braun", 30, 8_000);
            Auto a1 = new Auto("rot", 3);
            Auto a2 = new Auto("grün", 5);

            // f1.DruckeDatenblatt();
            // m1.DruckeDatenblatt();
            // m2.DruckeDatenblatt();
            // a1.DruckeDatenblatt();
            // a2.DruckeDatenblatt();

            Auto[] autos = new Auto[2];
            Motorrad[] motorraeder = new Motorrad[2];
            Fahrzeug[] fahrzeuge = new Fahrzeug[5];

            fahrzeuge[0] = new Auto("schwarz", 3);
            fahrzeuge[1] = a1;
            fahrzeuge[2] = a2;
            fahrzeuge[3] = m1;
            fahrzeuge[4] = m2;


            foreach (Auto fahrzeug in fahrzeuge)
            {
                fahrzeug.Fahren(100);
                fahrzeug.DruckeDatenblatt();
                Console.WriteLine(fahrzeug.ToString());
            }
        }
    }
}