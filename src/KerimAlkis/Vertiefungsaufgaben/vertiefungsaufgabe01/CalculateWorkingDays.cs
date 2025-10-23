using System.Globalization;

namespace Appdevhb25.KerimAlkis.Vertiefungsaufgabe01
{
    public class CalculateWorkingDays
    {
        public static void Start()
        {
            CultureInfo austrian = new CultureInfo("de-AT");
            DateTime datum;
            do
            {
                System.Console.WriteLine("CalculateWorkingDays");
                Console.Write("Gib ein Datum ein (Format: TT.MM.JJJJ): ");
                string input = Console.ReadLine();
                try
                {
                    datum = DateTime.ParseExact(input, "dd.MM.yyyy", austrian);
                    break;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Try again");
                }

            } while (true);

            int arbeitstage = CalculateWorkingDaysMethode(datum.Year, datum.Month);
            System.Console.WriteLine("Der Monat "+ datum.ToString("MMMM") + " im Jahr "+ datum.Year + " hat "+ arbeitstage+ " Arbeitstage");
        }
        public static int CalculateWorkingDaysMethode(int jahr, int monat)
        {
            DateOnly datum = new DateOnly(jahr, monat, 1);

            int arbeitstage = 0;

            while (datum.Month == monat)
            {
                if (datum.DayOfWeek == DayOfWeek.Monday ||
                datum.DayOfWeek == DayOfWeek.Tuesday ||
                datum.DayOfWeek == DayOfWeek.Wednesday ||
                datum.DayOfWeek == DayOfWeek.Thursday ||
                datum.DayOfWeek == DayOfWeek.Friday
                )
                {
                    arbeitstage++;
                }
                datum = datum.AddDays(1);
            }

            return arbeitstage;
        }
    }
}