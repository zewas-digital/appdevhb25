using System.Globalization;

namespace Appdevhb25.JulianMatt.Aufgabe65
{
    public class Cars2
    {

        public static void Start65()
        {
            PartList();
        }

        public static void PartList()
        {
            int CountOfCarsThatwhereUsed = 0;
            System.Console.WriteLine("Wie viele Autos wollen sie Eintragen: ");
            int countOfCars = Convert.ToInt32(Console.ReadLine());
            Car2[] Cars = new Car2[countOfCars];


            for (int i = 0; i < Cars.Length; i++)
            {
                System.Console.WriteLine("Farbe des Autos: ");
                Cars[i] = new Car2();
                Cars[i].Colour = Console.ReadLine();
                System.Console.WriteLine("Kilometer des Autos: ");

                Cars[i].Kilometers = Convert.ToDouble(Console.ReadLine());
                System.Console.WriteLine("Buchstaben des Kennzeichen: ");

                Cars[i].LicensePlateLetter = Console.ReadLine();
                System.Console.WriteLine("Nummern des Kennzeichen: ");

                Cars[i].LicensePlateNumbers = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("Wie viel verbrauch hat das Auto: ");

                Cars[i].Usage = Convert.ToDouble(Console.ReadLine());
                CountOfCarsThatwhereUsed++;
            }

            Console.Clear();

            Print(Cars, CountOfCarsThatwhereUsed);


        }

        public static void Print(Car2[] Cars, int CountOfCarsThatwhereUsed)
        {
            for (int i = 0; i < CountOfCarsThatwhereUsed; i++)
            {
                Cars[i].PrintColour();
                Cars[i].PrintKilometers();
                Cars[i].PrintLicensePlate();
                Cars[i].PrintUsage();

                System.Console.WriteLine("Wurde mit diesem Auto Mehr gefahren? Ja/Nein");
                string driverChecker = Console.ReadLine();

                if (driverChecker == "Ja")
                {
                    Cars[i].KilometersUpcounter(Cars, i);
                }
                else if (driverChecker == "Nein")
                {
                    
                }
                else
                {

                }
            }

        }


    }
}