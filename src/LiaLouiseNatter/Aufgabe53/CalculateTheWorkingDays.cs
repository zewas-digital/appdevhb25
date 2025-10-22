using System;
using System.Security.Principal;
using System.Text.RegularExpressions;
using System.Globalization;
using Microsoft.VisualBasic;

namespace Appdevhb25.LiaLouiseNatter.Aufgabe53
{
    public class CalculateTheWorkingDays
    {
        public static void Start()
        {
            CalculateWorkingDays(2025, 10);
        }
        private static void CalculateWorkingDays(int year, int month)
        {
            // Anz. an Tagen im Monat
            int workingdays = DateTime.DaysInMonth(year, month);
            DateTime first = new DateTime(year, month, 1);
            DateTime last = new DateTime(year, month, workingdays);
            // geht durch jeden Tag vom Monat
            for (DateTime now = last; now > first; now = now.AddDays(-1))
            {
                if (now.DayOfWeek == DayOfWeek.Sunday || now.DayOfWeek == DayOfWeek.Saturday)
                {
                    workingdays--;
                }
            }
            string monthname = new DateTime(year, month, 1).ToString("MMMM");
            System.Console.WriteLine($"Der Monat {monthname} im Jahr {year} hat {workingdays} Arbeitstage."); 
        }
    }
}

