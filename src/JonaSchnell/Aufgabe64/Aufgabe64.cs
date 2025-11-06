using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text.Json.Serialization;

namespace Appdevhb25.JonaSchnell.Aufgabe64
{
    public class Aufgabe64
    {

        public static void PrintCar()
        {
            Car[] cars = new Car[1];
            cars[0] = new Car();
            System.Console.WriteLine("Welche Farbe hat dein Auto?");
            cars[0].Farbe = Console.ReadLine();
            System.Console.WriteLine("Was ist dein Kilometerstand?");
            cars[0].Kilometerstand = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("Wieviele Kilometer bist du heute gefahren?");
            string inputString = Console.ReadLine();
            double input = Convert.ToDouble(inputString);
            System.Console.WriteLine("Was ist dein Kennzeichen?");
            cars[0].Kennzeichen = Console.ReadLine();
            System.Console.WriteLine("Wieviel Liter braucht dein auto pro 100 Km.");
            string inputbenzin = Console.ReadLine();
            double inputLiter = Convert.ToDouble(inputbenzin);
            cars[0].Verbrauch = inputLiter / 100 * input;
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine("Dein Auto ist " + cars[i].Farbe);
                cars[i].Kilometerstand = cars[i].Kilometerstand - input;
                Console.WriteLine("Bevor du gefahren bist hattest du " + cars[i].Kilometerstand + " km auf dem Kilometerstand.");
                cars[i].Kilometerstand = cars[i].Kilometerstand + input;
                Console.WriteLine("Jetzt hast du " + cars[i].Kilometerstand + " km auf dem Kilometerstand, da du " + input + "km gefahren bist.");
                Console.WriteLine("Dein Kennzeichen ist " + cars[i].Kennzeichen);
                Console.WriteLine("und dein auto hat ca " + cars[i].Verbrauch + " Liter verbraucht.");
            }
        }
    }
}
