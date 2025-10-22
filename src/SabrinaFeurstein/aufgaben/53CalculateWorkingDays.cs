using System;

namespace Appdevhb25.SabrinaFeurstein.aufgaben
{

    public class WorkingDays
    {
        public static void Start()
        {
            Console.WriteLine(CalculateWorkingDays(2025, 10));
        }
        
        public static string CalculateWorkingDays(int year, int month)
        {
            DateTime date = new DateTime(2025, 10, 1);
            DateTime dateTemp = date;
            int workingDays = 0;
            
            while (dateTemp.Month == date.Month)
            {
                if (dateTemp.DayOfWeek == DayOfWeek.Monday || dateTemp.DayOfWeek == DayOfWeek.Tuesday || dateTemp.DayOfWeek == DayOfWeek.Wednesday || dateTemp.DayOfWeek == DayOfWeek.Thursday || dateTemp.DayOfWeek == DayOfWeek.Friday)
                    workingDays += 1;
                dateTemp = dateTemp.AddDays(1);
            }

            string days = $"Der Monat {date.ToString("MMMM")} im Jahr {date.ToString("yyyy")} hat {workingDays} Arbeitstage.";
            return days;
        }
    }
}