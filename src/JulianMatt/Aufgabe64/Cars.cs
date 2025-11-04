using System.Globalization;

namespace Appdevhb25.JulianMatt.Aufgabe64
{
    public class Cars
    {

        public static void Start64()
        {
            PartList();
        }

        public static void PartList()
        {
            int CountOfCarsThatwhereUsed = 0;
            System.Console.WriteLine("Wie viele Autos wollen sie Eintragen: ");
            int countOfCars = Convert.ToInt32(Console.ReadLine());
            Car[] Cars = new Car[countOfCars];

            
            for ( int i = 0; i < Cars.Length; i++)
            {
                System.Console.WriteLine("Farbe des Autos: ");
                Cars[i] = new Car();
                Cars[i].Colour = Console.ReadLine();
                System.Console.WriteLine("Kilometer des Autos: ");
                
                Cars[i].Kilometers = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("Buchstaben des Kennzeichen: ");
               
                Cars[i].LicensePlateLetter = Console.ReadLine();
                System.Console.WriteLine("Nummern des Kennzeichen: ");
               
                Cars[i].LicensePlateNumbers = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("Wie viel verbrauch hat das Auto: ");
               
                Cars[i].Usage = Convert.ToInt32(Console.ReadLine());
                CountOfCarsThatwhereUsed++;
            }

            //Console.Clear();

            for (int i = 0; i < CountOfCarsThatwhereUsed; i++)
            {
                Cars[i].PrintColour(Cars[i].Colour);
                Cars[i].PrintKilometers(Cars[i].Kilometers);
                Cars[i].PrintLicensePlate(Cars[i].LicensePlateLetter, Cars[i].LicensePlateNumbers);
                Cars[i].PrintUsage(Cars[i].Usage);
            }
            

        }


    }
}