using System;

namespace Appdevhb25.SelinUlutuerk.Aufgabe69
{
    public class Intro
    {
        public static void Start()
        {
            Motorrad[] motorraeder = new Motorrad[3];

            motorraeder[0] = new Motorrad(50_000, "schwarz", 105, 7_100.00, "DO-SU 23");
            motorraeder[1] = new Motorrad(78_000, "rot", 220, 12_200.50, "B-AB 736");
            motorraeder[2] = new Motorrad(1_000, "blau", 63, 2_500.20, "DO-FT 864");

            Motorrad.BerechneDurchschnittsumsatz();
        }
    }
}