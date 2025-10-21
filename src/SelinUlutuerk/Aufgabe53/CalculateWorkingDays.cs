using System;
using System.Globalization;
using System.Security.Cryptography;

namespace Appdevhb25.SelinUlutuerk.Aufgabe53
{
    class CalculateWorkingDays
    {
        public static void Start()
        {
            CultureInfo austrian = new CultureInfo("de-AT");

            System.Console.WriteLine("Aus welchem Monat möchtest du die Arbeitsstage erfahren?");
            int month = Convert.ToInt16(Console.ReadLine());

            System.Console.WriteLine("Und aus welchem Jahr möchtest du die Arbeitsstage erfahren?");
            int year = Convert.ToInt16(Console.ReadLine());

            CalculateWorkingDay(year, month);
            
        }
        
        public static void CalculateWorkingDay(int year, int month)
        {
            int alldays = DateTime.DaysInMonth(year, month);
            int workDays = 0;

            for(int i = 1; i <= alldays; i++)
            {
                DateTime date = new DateTime(year, month, i);

                if(date.DayOfWeek != DayOfWeek.Sunday && date.DayOfWeek != DayOfWeek.Saturday)
                {
                    workDays++;
                }
            }
             
            System.Console.WriteLine("Der Monat {0} im Jahr {1} hat {2} Arbeitstage", month, year, workDays);
        }
    }
}