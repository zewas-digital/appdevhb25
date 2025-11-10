using System.Runtime.InteropServices;

namespace Appdevhb25.SabrinaFeurstein.aufgaben.aufgabe64und65
{
    public class Cars
    {
        public static void Start()
        {
            Car[] cars =
            [
                new Car("gelb", 10489, "B-PL345", 7.3),
                new Car("blau", 7060.2, "DO-LR572", 6),
                new Car("grau", 2349.9, "FK-SR514", 4.5),
            ];

            for (int i = 0; i < cars.Length; i++)
            {
                Console.Write($"Auto {i + 1}: ");
                cars[i].PrintCar();
            }

            cars[0].Fahren(3000);
        }
    }
}