using System;
using System.Globalization;

namespace Appdevhb25.SashaLeonardoMattes.Aufgabe43
{

    public class CalculateSundays
    {

        public static void StartCalculateSundays()
        {
            Console.WriteLine("----------Aufgabe 43----------");

            System.Console.WriteLine("Gib ein Datum ein:");
            DateTime currentDay = Helper.checkUserInputDate();
            currentDay = DateTime.Today;
            
            System.Console.WriteLine("Nächsten 3 Sonntage:");

            DateTime sunday = getNextSunday(currentDay);
            System.Console.WriteLine("1. " + sunday.Date.ToString("d"));
            System.Console.WriteLine("2. " + sunday.Date.AddDays(7).ToString("d, MMM, yyyy"));
            System.Console.WriteLine("3. " + sunday.Date.AddDays(14).ToString("F"));
            
        }
        
        public static DateTime getNextSunday(DateTime startDate)
        {
            if (startDate.DayOfWeek == DayOfWeek.Sunday)
            {
                startDate = startDate.AddDays(1);
            }

            do
            {
                if (startDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    DateTime sunday = startDate.Date;
                    return sunday;
                }
                else
                {
                    startDate = startDate.AddDays(1);
                }

            } while (true);
        }

    

    }
}
