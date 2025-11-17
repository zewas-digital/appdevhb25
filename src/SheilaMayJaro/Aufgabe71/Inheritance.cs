using System.Formats.Asn1;
using Appdevhb25.SheilaMayJaro.Aufgabe71;

namespace Appdevhb25.SheilaMayJaro.Aufgabe71
{
    public class Inheritance
    {
        public static void Start()
        {
            System.Console.WriteLine("Aufgabe 70)");

            Motorbike m1 = new Motorbike("grün", 47.8, 10_000);
            Motorbike m2 = new Motorbike("blau", 74.8, 20_000);

            Car c1 = new Car("gelb", 3);
            c1.Kilometrage = 6;
            Car c2 = new Car("rot", 5);
            // Motorbike[] motorbikes = new Motorbike[2];
            Vehicle[] vehicles = [c1, m1, c2, m2];
            
            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.Driving(100);
                vehicle.PrintDataSheet();
                System.Console.WriteLine(vehicle.ToString());
                System.Console.WriteLine("--------------------------------------------");
            }
            System.Console.WriteLine();
            System.Console.WriteLine(Motorbike.CalculateAverageSalesPerMotorbike());
            System.Console.WriteLine(Vehicle.NumberOfProducedVehicles);
            System.Console.WriteLine(Car.NumberOfProducedVehicles);

            //Vehicle kann nicht auf die Attribute/Methoden von Car oder Motorbike zugreifen
            
        }
    }
}