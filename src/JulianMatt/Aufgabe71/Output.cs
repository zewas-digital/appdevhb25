using System;

namespace Appdevhb25.JulianMatt.Aufgabe71
{
    public class Output
    {
        public static void Start71()
        {
            Fahrzeug[] fahrzeuge = new Fahrzeug[4];
            fahrzeuge[0] = new Auto("Blau", "B 123 XY", 15000, 4);
            fahrzeuge[1] = new Motorrad("Schwarz", "DO 999 AB", 8000, 120, 12000);
            fahrzeuge[2] = new Auto("Rot", "K 456 CD", 32000, 5);
            fahrzeuge[3] = new Motorrad("Silber", "M 111 ZZ", 1200, 80, 9000);

            foreach (var f in fahrzeuge)
            {
                f.PrintVehicleInfo();
                f.Fahren();
                Console.WriteLine(f.ToString());
                Console.WriteLine("-----------------------------");
            }

            Console.WriteLine("Gesamt produzierte Fahrzeuge: " + Fahrzeug.CountOfProducedVehicles);
        }
    }
}
