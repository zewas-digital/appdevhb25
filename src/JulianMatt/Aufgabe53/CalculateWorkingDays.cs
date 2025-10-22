using System.Globalization;

namespace Appdevhb25.JulianMatt.Aufgabe53
{
    public class CalculateWorkingDays
    {

        public static void Start53()
        {
            CalcSundays();
        }

        public static void CalcSundays()
        {

            System.Console.WriteLine("Geben sie das Datum des monats an in dem sie checken wollen wei viel Arbeitstage da sind(2025.10.01)");
            Console.WriteLine("Bitte gib das Jahr ein:");

            string yearAsString = Console.ReadLine();
            int year = Convert.ToInt32(yearAsString);

            Console.WriteLine("Bitte gib den Monat ein:");
            string monthAsString = Console.ReadLine();
            int.TryParse(monthAsString, out int month);

            int day = 01;  
            DateTime currentDay = new DateTime(year, month, day);
            int daysInMonth = System.DateTime.DaysInMonth(currentDay.Year, currentDay.Month);
            int countWorkDays = 0;                  
            
            for (int i = 0; i < daysInMonth; i++)
            {
                DateTime date2 = currentDay.AddDays(i);
                DayOfWeek dayOfWeek = date2.DayOfWeek;

                if (date2.DayOfWeek == DayOfWeek.Saturday || date2.DayOfWeek == DayOfWeek.Sunday)
                {

                }
                else
                {
                    countWorkDays += 1;
                }
            }
            System.Console.WriteLine(countWorkDays);         
        }


    }
}