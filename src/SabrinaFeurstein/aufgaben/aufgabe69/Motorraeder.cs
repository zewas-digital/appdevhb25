namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe69
{
    public class Motorraeder
    {
        public static void Start()
        {
            Motorrad[] motorraeder =
            [
                new Motorrad(255903, "schwarz", 20, 2200, "B-45WL"),
                new Motorrad("rot", 15, 5000, "DO-568E")
            ];

            Console.WriteLine($"Anzahl der produzierten Motorrädern: {Motorrad.ProduzierteMotorraeder}\nDurchschnittlicher Umsatz: {Motorrad.BerechneDurchschnittsUmsatz():F2} $");
        }
    }
}