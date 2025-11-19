using System.Globalization;

namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe53
{
    public class CalculateWorkingDays
    {
        public static void Start()
        {
            CalculateWorkingDaysInOneYear();
        }
        public static void CalculateWorkingDaysInOneYear()
        {
            CultureInfo austria = new CultureInfo("de-AT");
            for (int i = 1; i <= 12; i++)
            {
                DateTime date = new DateTime(2025, i, 1);
                int daysInMonth = DateTime.DaysInMonth(2025, i);
                int foundWorkDays = 0;

                for (int j = 0; j < daysInMonth; j++)
                {
                    if (date.DayOfWeek == DayOfWeek.Monday || date.DayOfWeek == DayOfWeek.Tuesday || date.DayOfWeek == DayOfWeek.Wednesday || date.DayOfWeek == DayOfWeek.Thursday || date.DayOfWeek == DayOfWeek.Friday)
                    {
                        foundWorkDays = foundWorkDays + 1;
                    }
                    date = date.AddDays(1);
                }
                date = date.AddDays(-1);
                Console.WriteLine("So viel Arbeitstage hat der " + date.ToString("MMMM", austria) + " im Jahr " + date.ToString("yyyy") + ": " + foundWorkDays);
            }
        }
    }
}