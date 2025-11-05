using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using Appdevhb25.NoahHois.CodewarsAufgabe1;

namespace Appdevhb25.NoahHois.Aufgabe64
{
    public class Car
    {
        public string Color;
        public int Mileage;
        public string Mark;
        public decimal Consumption;
        public void PrintCar()
        {
            Console.WriteLine($"Die Autofarbe ist {Color} es hat {Mileage} km aufm Tacho das Kennzeichen ist {Mark} und es Verbraucht {Consumption} Liter pro 100 km.");
        }
        // public void Fahren()
        // {
        //     Console.WriteLine("Gib den neuen Kilometerstand ein: ");
        //     NewMileageInput = Console.ReadLine();
        //     int NewMileage = Convert.ToInt32(NewMileageInput);
        //     Console.WriteLine("Die Distanz beträgt: " + NewMileage);
        //     NewMileage += Mileage;
        //     Console.WriteLine($"Der neue Kilometerstand ist {NewMileage} km.");
        // }
        public void Fahren(int Distanz)
        {
            Console.WriteLine($"Der alte Kilometerstand ist {Mileage} km.");
            Console.WriteLine("Die Distanz beträgt: " + Distanz);
            Mileage += Distanz;
            Console.WriteLine($"Der neue Kilometerstand ist {Mileage} km.");
        }
    }
}