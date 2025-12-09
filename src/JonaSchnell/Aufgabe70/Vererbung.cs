using System;

namespace Appdevhb25.JonaSchnell.Aufgabe70
{
    class Vererbung
    {
        public static void Start()
        {
            Fahrzeug f1 = new Fahrzeug("schwarz");

            Motorrad m1 = new Motorrad("blau", 70, 4_000);
            Motorrad m2 = new Motorrad("braun", 30, 8_000);
            Auto a1 = new Auto("rot", 3);
            Auto a2 = new Auto("grün", 5);

            f1.DruckeDatenblatt();
            m1.DruckeDatenblatt();
            m2.DruckeDatenblatt();
            a1.DruckeDatenblatt();
            a2.DruckeDatenblatt();
        }
    }
}