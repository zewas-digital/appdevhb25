using System;
namespace Appdevhb25.KatjaHaemmerli.Aufgabe53
{
    public  class CalculateWorkingDays
    {
        // Erstelle eine Methode welche als Parameter das Jahr und den Monat nimmt
        // und die Anzahl der Arbeitstage zurückgibt (Mo-Fr). 
        public static void CalcWorkingDays(int year, int month)
        {
            DateTime today = new DateTime(year, month, 1); // 1 für erster Tag des Monats
            int workdays = 0;

            while (today.Month == month && today.Year == year)
            {
                if (today.DayOfWeek != DayOfWeek.Saturday && today.DayOfWeek != DayOfWeek.Sunday)
                {
                    workdays++;
                }
                today = today.AddDays(1); // Tag hinzufügen            
            }           
            System.Console.WriteLine($"Der {month}. Monat im Jahr {year} hat {workdays} Arbeitstage.");            
        }
    }
}