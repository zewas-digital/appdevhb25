using System.Globalization;

namespace Appdevhb25.LauraKatharinaBertsch.Aufgabe52
{
    public class CalculateSundays
    {
        public static void Start()
        {
            Console.WriteLine("Die folgenden Datums sind die Sonntage der nächsten drei Wochen");
            DateTime date = new DateTime(2025, 10, 22);
            int foundSundays = 0;
            CultureInfo austria = new CultureInfo("de-AT");

            while (foundSundays < 3)
            {
                if (date.DayOfWeek == DayOfWeek.Sunday)
                {
                    Console.WriteLine(date.ToString("dd.MM.yyyy", austria));
                    foundSundays = foundSundays + 1;
                }
                date = date.AddDays(1);
            }
        }
    }
}