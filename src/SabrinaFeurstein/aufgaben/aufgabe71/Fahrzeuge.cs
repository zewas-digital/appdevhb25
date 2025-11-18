namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe71
{
    public class Fahrzeuge
    {
        public static void Start()
        {
            Auto[] autos =
            [
                new Auto("gelb", "B-345PL", 23189, 5),
                new Auto("weiß", "DO-572LR", 504, 3)
            ];

            Motorrad[] motorraeder =
            [
                new Motorrad("schwarz", "B-45WL", 98, 25, 10000),
                new Motorrad("rot", "DO-568E", 1560, 20, 5000)
            ];

            Fahrzeug[] fahrzeuge = new Fahrzeug[4];
            fahrzeuge[0] = autos[0];
            fahrzeuge[1] = autos[1];
            fahrzeuge[2] = motorraeder[0];
            fahrzeuge[3] = motorraeder[1];
            
            Console.WriteLine(fahrzeuge[3].ToString());
            autos[0].Fahren(100);

            for (int i = 0; i < autos.Length; i++)
            {
                Console.WriteLine($"Auto {i + 1}");
                Console.WriteLine(autos[i].ToString());
                Console.WriteLine();
            }

            for (int i = 0; i < motorraeder.Length; i++)
            {
                Console.WriteLine($"Motorrad {i + 1}");
                Console.WriteLine(motorraeder[i].ToString());
                Console.WriteLine();
            }
            Console.WriteLine("Anzahl der produzierten Autos: " + Auto.AnzahlDerProduziertenAutos);
            Console.WriteLine("Anzahl der produzierten Motorräder: " + Motorrad.AnzahlDerProduziertenMotorraeder);
            Console.WriteLine("Durchschnittlicher Umsatz pro Motorrad: " + Motorrad.BerechneDurchschnittsUmsatz());
            Console.WriteLine("Anzahl der produzierten Fahrzeuge insgesamt: " + Fahrzeug.AnzahlDerProduziertenFahrzeuge);
        }
    }
}