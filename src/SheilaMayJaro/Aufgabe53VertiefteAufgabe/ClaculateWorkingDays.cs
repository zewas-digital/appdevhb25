using System; 
namespace Appdevhb25.SheilaMayJaro.Aufgabe53
{
    public class CalculateWorkingDays
    {
        public static void Start()
        {
            System.Console.WriteLine("Aufgabe 53)");
            /*
            Erstelle eine Methode welche als Parameter das Jahr und den Monat nimmt und die Anzahl der Arbeitstage zurückgibt (Mo-Fr). Feiertage müssen nicht berücksichtigt werden.
            */

            WorkingDaysPerMonth(2025, 10); 

        }
        public static void WorkingDaysPerMonth(int year, int month)
        {
            //Die Daten, die an einem Mo - Fr sind zusammenzählen 
            DateTime startDate = new DateTime(year, month, 1);
            int workingDays = 0;

            while (startDate.Month == month && startDate.Year == year)
            {
                if (startDate.DayOfWeek != DayOfWeek.Saturday && startDate.DayOfWeek != DayOfWeek.Sunday)
                {
                    workingDays++;
                }
                startDate = startDate.AddDays(1);
            }
            System.Console.WriteLine($"Der Monat {month} im Jahr {year} hat {workingDays} Arbeitstage.");
        }
    }
}